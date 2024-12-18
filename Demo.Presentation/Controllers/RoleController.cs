using Demo.DAL.Models;
using Demo.Presentation.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.Presentation.Controllers
{
    [Authorize(Roles ="Admin")]
    public class RoleController : Controller
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<ApplicationUser> _userManager;

        public RoleController(RoleManager<IdentityRole> roleManager, UserManager<ApplicationUser> userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }
        public async Task<IActionResult> Index(string search)
        {
            var roles = Enumerable.Empty<RoleViewModel>();
            if (string.IsNullOrEmpty(search))
            {
                roles = await _roleManager.Roles.Select(R => new RoleViewModel()
                {
                    Id = R.Id,
                    RoleName = R.Name,
                }).ToListAsync();
            }
            else
            {

                roles = await _roleManager.Roles.Where(U => U.Name.ToLower()
                           .Contains(search.ToLower()))
                           .Select(R => new RoleViewModel()
                           {
                               Id = R.Id,
                               RoleName = R.Name
                           }).ToListAsync();
            }

            return View(roles);
        }
        public async Task<IActionResult> Details(string? id, string viewName = "Details")
        {
            if (id is null)
                return BadRequest();
            var roleId = await _roleManager.FindByIdAsync(id);
            if (roleId is null)
                return NotFound();
            var role = new RoleViewModel()
            {
                Id = roleId.Id,
                RoleName = roleId.Name,
            };
            return View(viewName, role);
        }
        public async Task<IActionResult> Edit(string? id)
        {
            return await Details(id, "Edit");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit([FromRoute] string? id, RoleViewModel model)

        {
            if (id != model.Id)
                return BadRequest();
            if (ModelState.IsValid)
            {
                var roleId = await _roleManager.FindByIdAsync(id);
                if (roleId is null)
                    return NotFound();
                roleId.Name = model.RoleName;

                await _roleManager.UpdateAsync(roleId);
                return RedirectToAction("Index");
            }
            return View(model);
        }
        public async Task<IActionResult> Delete(string? id)
        {
            return await Details(id, "Delete");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete([FromRoute] string? id, RoleViewModel model)
        {
            if (id != model.Id)
                return BadRequest();
            if (ModelState.IsValid)
            {
                var roleId = await _roleManager.FindByIdAsync(id);
                if (roleId is null)
                    return NotFound();
                await _roleManager.DeleteAsync(roleId);
                return RedirectToAction("Index");
            }
            return View(model);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(RoleViewModel model)
        {
            if (ModelState.IsValid)
            {
                var role = new IdentityRole()
                {

                    Name = model.RoleName,
                };
                var result = await _roleManager.CreateAsync(role);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index");
                }
            }
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> AddOrRemoveUser(string roleId)
        {

            var role = await _roleManager.FindByIdAsync(roleId);
            if (role is null)
                return NotFound();
            ViewData["RoleId"] = roleId;
            var usersInRole = new List<UsersInRoleViewModel>();
            var users = await _userManager.Users.ToListAsync();
            foreach (var user in users)
            {
                var userInRole = new UsersInRoleViewModel()
                {
                    UserId = user.Id,
                    UserName = user.UserName,
                };
                if (await _userManager.IsInRoleAsync(user, role.Name))
                {
                    userInRole.IsSelected = true;
                }
                else
                {
                    userInRole.IsSelected = false;
                }
                usersInRole.Add(userInRole);
            }
            return View(usersInRole);
        }
        [HttpPost]
        public async Task<IActionResult> AddOrRemoveUser(string roleId, List<UsersInRoleViewModel> models)
        {
            var role = await _roleManager.FindByIdAsync(roleId);
            if (role is null)
                return NotFound();
            if (ModelState.IsValid)
            {
                foreach (var user in models)
                {
                    var appUser = await _userManager.FindByIdAsync(user.UserId);
                    if (appUser is not null)
                    {
                        if (user.IsSelected & !await _userManager.IsInRoleAsync(appUser, role.Name))
                        {
                            await _userManager.AddToRoleAsync(appUser, role.Name);
                        }
                        else if (!user.IsSelected & await _userManager.IsInRoleAsync(appUser, role.Name))
                        {
                            await _userManager.RemoveFromRoleAsync(appUser, role.Name);
                        }
                    }

                }
                return RedirectToAction("Edit", new {id=roleId});
            }
            return View(models);
        }
    }
}
