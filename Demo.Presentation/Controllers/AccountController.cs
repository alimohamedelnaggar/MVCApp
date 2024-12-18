using Demo.DAL.Models;
using Demo.Presentation.Helper;
using Demo.Presentation.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Demo.Presentation.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> _user;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public AccountController(UserManager<ApplicationUser> user, SignInManager<ApplicationUser> signInManager)
        {
            _user = user;
            _signInManager = signInManager;
        }

        public IActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SignUp(SignUpViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await _user.FindByNameAsync(model.UserName);
                if (user == null)
                {
                    user = await _user.FindByEmailAsync(model.Email);
                    if (user == null)
                    {
                        user = new ApplicationUser()
                        {
                            UserName = model.UserName,
                            Email = model.Email,
                            FirstName = model.FirstName,
                            LastName = model.LastName,
                            IsAgree = model.IsAgree,


                        };
                        var result = await _user.CreateAsync(user, model.Password);
                        if (result.Succeeded)
                        {
                            return RedirectToAction(nameof(SignIn));
                        }
                        foreach (var error in result.Errors)
                        {
                            ModelState.AddModelError(string.Empty, error.Description);
                        }
                    }
                }
                ModelState.AddModelError(string.Empty, "User already exist (:");
            }

            return View(model);
        }
        public IActionResult SignIn()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SignIn(SignInViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await _user.FindByEmailAsync(model.Email);
                if (user is not null)
                {
                    var flag = await _user.CheckPasswordAsync(user, model.Password);
                    if (flag)
                    {
                        var result = await _signInManager.PasswordSignInAsync(user, model.Password, model.RememberMe, false);
                        if (result.Succeeded)
                        {

                            return RedirectToAction(nameof(HomeController.Index), "Home");
                        }

                    }
                }
                ModelState.AddModelError(string.Empty, "Invalid Login");
            }
            return View(model);
        }

        public new async Task<IActionResult> SignOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction(nameof(SignIn));
        }
        [HttpGet]
        public IActionResult ForgetPassword()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SendResetPasswordUrl(ForgetPasswordViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await _user.FindByEmailAsync(model.Email);
                if (user is not null)
                {
                    var token = await _user.GeneratePasswordResetTokenAsync(user);
                    var url = Url.Action("ResetPassword", "Account", new { email = model.Email, token }, Request.Scheme);
                    var email = new Email()
                    {
                        To = model.Email,
                        Subject = "Reset Password",
                        Body = url
                    };
                    EmailSettings.SendEmail(email);
                    return RedirectToAction(nameof(CheckYourInbox));
                }
                ModelState.AddModelError(string.Empty, "Invalid Operation , please try again");
            }
            return View(nameof(ForgetPassword), model);
        }
        public IActionResult CheckYourInbox()
        {
            return View();
        }
        [HttpGet]
        public IActionResult ResetPassWord(string email, string token)
        {
            TempData["email"] = email;
            TempData["token"] = token;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ResetPassword(ResetPasswordViewModel model)
        {
            if (ModelState.IsValid)
            {

                var email = TempData["email"] as string;
                var token = TempData["token"] as string;
                var user = await _user.FindByEmailAsync(email);
                if (user is not null)
                {

                    var result = await _user.ResetPasswordAsync(user, token, model.Password);
                    if (result.Succeeded)
                    {
                        return RedirectToAction(nameof(SignIn));
                    }
                }

            }
            ModelState.AddModelError(string.Empty, "Invalid");
            return View(model);
        }

        public IActionResult AccessDenied() {  return View(); }
    }
}
