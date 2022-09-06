using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SayItWebsiteNet5.Models;
using SayItWebsiteNet5.Data;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace SayItWebsiteNet5.Controllers
{
    public class UserController : Controller
    {
        private UserManager<ApplicationUser> _userManager;
        private RoleManager<ApplicationRole> _roleManager;


        public UserController(UserManager<ApplicationUser> userManager, RoleManager<ApplicationRole> roleManager)
        {
            this._userManager = userManager;
            _roleManager = roleManager;
        }
        public IActionResult Create()
        {
            ViewBag.roles = _roleManager.Roles;
            return View();
        }
        [Authorize(Roles = "Admin")]
        public IActionResult CreateRole()
        {

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(User user)
        {

            if (ModelState.IsValid)
            {
                ApplicationUser appUser = new ApplicationUser
                {
                    UserName = user.UserName

                };
                ViewBag.test = null;

                IdentityResult result = await _userManager.CreateAsync(appUser, user.Password);

                if (result.Succeeded)
                {
                    ViewBag.Message = "Bruger Oprettet";

                    //give user account roles
                    user.Roles.RemoveAll(item => item == null);
                    if (user.Roles.Count > 0)
                    {
                        await _userManager.AddToRolesAsync(appUser, user.Roles);

                    }

                    //create student 
                    var student = new Student();
                    student._Id = appUser.Id;
                    student.Name = user.Name;
                    student.Surname = user.Surname;
                    student.EnrollmentCreated = System.DateTime.Now;
                    student.DaysTotal = 0;
                    student.AbsentDaysTotal = 0;
                    student.Notes = new List<Note>();
                    student.ActiveEvents = null;
                    student.Roles = user.Roles;
                    student.Active = true;


                    //add to student table in db
                    DBFactory dBFactory = new DBFactory();
                    dBFactory.CreateDocument<Student>("SayItWebsiteInfo", "Students", student);



                }
                else
                {
                    foreach (IdentityError error in result.Errors)
                    {
                        ViewBag.Error = error.Description;
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }

            ViewBag.roles = _roleManager.Roles;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateRole(UserRole userRole)
        {
            IdentityResult result = await _roleManager.CreateAsync(new ApplicationRole() { Name = userRole.RoleName });

            if (result.Succeeded)
            {
                ViewBag.Message = "Role Created";
            }
            else
            {
                foreach (IdentityError error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }

            return View();

        }

        //[HttpPost]
        //public async Task<>
    }
}
