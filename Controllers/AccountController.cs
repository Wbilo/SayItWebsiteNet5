using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SayItWebsiteNet5.Models;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace SayItWebsiteNet5.Controllers
{
    public class AccountController : Controller
    {

        private UserManager<ApplicationUser> _userManager;
        private SignInManager<ApplicationUser> _signInManager;

        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            this._userManager = userManager;
            this._signInManager = signInManager;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login([Required]string name, [Required]string password, string returnurl)
        {
            if (ModelState.IsValid)
            {
                ApplicationUser appUser = await _userManager.FindByNameAsync(name);
                if(appUser != null)
                {
                    Microsoft.AspNetCore.Identity.SignInResult result = await _signInManager.PasswordSignInAsync(appUser, password, true, false);
                    if (result.Succeeded)
                    {
                        return Redirect(returnurl ?? "/");
                    }
                    
                }
                ModelState.AddModelError("LoginFailure", "Login Failed: Invalid Username or Password");
            }
            return View(ModelState);
        }

        [Authorize]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index","home");
        }
    }
}
