using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using montanari.giorgia._5H.SecondaWeb.dto;
using montanari.giorgia._5H.SecondaWeb.Models;
using Microsoft.AspNetCore.Identity;

namespace montanari.giorgia._5H.SecondaWeb.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public AccountController(UserManager<IdentityUser> userManager,
                              SignInManager<IdentityUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginDto user)
        {
            if (ModelState.IsValid)
            {
               var result = await _signInManager.PasswordSignInAsync(user.Email,user.Password, user.RememberMe, false);

               if (result.Succeeded)
                {
                   // Se l'utente fa login correttamente, entra.
                   return RedirectToAction("Privacy", "TXT");
                }
                else
                {

                   // ...altrimenti meglio non dare troppo info a chi ci prova
                   // meglio un generico errore,
                   ModelState.AddModelError(string.Empty, "Login error");
                }
            }
            return View(user); 
        }
        public IActionResult Registra()
        {
            return View();
            //return View("_Registrati");
            //return View();
        }

        [HttpPost]
        public async Task<IActionResult> Registra(RegistraDto model)
        {
            if (ModelState.IsValid)
            {
                var user = new IdentityUser
                {
                    UserName = model.Email,
                    Email = model.Email,
                };

                var result = await _userManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {
                     //await _signInManager.SignInAsync(user, isPersistent: false);
                     return RedirectToAction("Index", "TXT");
                }

                foreach (var error in result.Errors)
                    ModelState.AddModelError("", error.Description);

                ModelState.AddModelError(string.Empty, "Invalid Login Attempt");
            }
            return View(model);
        }
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index","TXT");
        }
      

    }

    internal class ChildActionOnlyAttribute : Attribute
    {
    }
}
