using Aldente.Models;
using Aldente.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Aldente.Controllers
{
    public class UserController : Controller
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signInManager;

        public UserController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }
        public IActionResult Index() => View();
        public IActionResult SingIn() => View();
        [HttpPost]
        public async Task<IActionResult> Registro(SingInModel modelo)
        {
            if (!ModelState.IsValid)
            {
                return View(modelo);
            }

            var user = new IdentityUser() { Email = modelo.Email, UserName = modelo.Email };

            var result = await userManager.CreateAsync(user, password: modelo.Password);

            var claimsPersonalizados = new List<Claim>()
            {
                new Claim(Constan.ClaimTenantId, user.Id)
            };

            await userManager.AddClaimsAsync(user, claimsPersonalizados);

            if (result.Succeeded)
            {
                await signInManager.SignInAsync(user, isPersistent: true);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
                return View(modelo);
            }

        }

        [HttpGet]
        public IActionResult Login() => View();
        
        [HttpPost]
        public async Task<IActionResult> Login(LoginModel modelo)
        {
            if (!ModelState.IsValid) return View(modelo);

            var result = await signInManager.PasswordSignInAsync(modelo.Email, modelo.Password, modelo.Recuerdame, lockoutOnFailure: false);

            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Nombre de usuario o password incorrecto.");
                return View(modelo);
            }
        }

    }
}
