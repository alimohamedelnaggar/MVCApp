using Demo.DAL.Models;
using Demo.Presentation.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Demo.Presentation.Controllers
{
     [Authorize(Roles = "Admin")]
    public class UserController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public UserController(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }
        public async Task<IActionResult> Index(string search)
        {
            var users = Enumerable.Empty<UserViewModel>();
            if (string.IsNullOrEmpty(search))
            {
                users = await _userManager.Users.Select(U => new UserViewModel()
                {
                    Id = U.Id,
                    FirstName = U.FirstName,
                    LastName = U.LastName,
                    Email = U.Email,
                    Roles = _userManager.GetRolesAsync(U).Result
                }).ToListAsync();
            }
            else
            {

                users = await _userManager.Users.Where(U => U.Email.ToLower()
                           .Contains(search.ToLower()))
                           .Select(U => new UserViewModel()
                           {
                               Id = U.Id,
                               FirstName = U.FirstName,
                               LastName = U.LastName,
                               Email = U.Email,
                               Roles = _userManager.GetRolesAsync(U).Result
                           }).ToListAsync();
            }

            return View(users);
        }
        public async Task<IActionResult> Details(string? id, string viewName = "Details")
        {
            if (id is null)
                return BadRequest();
            var userId = await _userManager.FindByIdAsync(id);
            if (userId is null)
                return NotFound();
            var user = new UserViewModel()
            {
                Id = userId.Id,
                FirstName = userId.FirstName,
                LastName = userId.LastName,
                Email = userId.Email,
                Roles = _userManager.GetRolesAsync(userId).Result
            };
            return View(viewName, user);
        }
        public async Task<IActionResult> Edit(string? id)
        {
            return await Details(id, "Edit");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit([FromRoute] string? id, UserViewModel model)

        {
            if (id != model.Id)
                return BadRequest();
            if (ModelState.IsValid)
            {
                var userId = await _userManager.FindByIdAsync(id);
                if (userId is null)
                    return NotFound();
                userId.FirstName = model.FirstName;
                userId.LastName = model.LastName;
                userId.Email = model.Email;
                await _userManager.UpdateAsync(userId);
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
        public async Task<IActionResult> Delete([FromRoute] string? id, UserViewModel model)
        {
            if (id != model.Id)
                return BadRequest();
            if (ModelState.IsValid)
            {
                var userId = await _userManager.FindByIdAsync(id);
                if (userId is null)
                    return NotFound();
                await _userManager.DeleteAsync(userId);
                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}
