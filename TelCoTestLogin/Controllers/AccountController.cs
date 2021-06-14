using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TelCoTestLogin.Entities;

namespace TelCoTestLogin.Controllers
{
    public class AccountController : Controller
    {
        //private readonly SignInManager<IdentityUser> _signInManager;

        public AccountController()
        {
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(Login user)
        {

            if (ModelState.IsValid)
            {
                //var result = await _signInManager.PasswordSignInAsync(user.Email, user.Password, user.RememberMe, false);
                if (user.Email == "naptay@12345" && user.Password == "naptay")
                {
                    return RedirectToAction("Index", "Home");
                }

                ModelState.AddModelError(string.Empty, "Invalid Login Attempt");

            }
            return View(user);
        }

        [AllowAnonymous]
        public async Task<IActionResult> Logout()
        {
            //await _signInManager.SignOutAsync();

            return RedirectToAction("Login");
        }
    }

}