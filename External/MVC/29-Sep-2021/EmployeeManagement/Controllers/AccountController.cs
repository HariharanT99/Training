using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BussinessObject.Model;
using DataAccess.Access;
using Microsoft.AspNetCore.Identity;

namespace EmployeeManagement.Controllers
{
    public class AccountController : Controller
    {
        private readonly AccountDAL _accountDAL;
        private readonly SignInManager<IdentityUser> _signInManager;

        public AccountController(AccountDAL accountDAL, SignInManager<IdentityUser> signInManager)
        {
            this._accountDAL = accountDAL;
            this._signInManager = signInManager;

        }
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(Register model)
        {
            if(ModelState.IsValid)
            {
                var result = await _accountDAL.CreateUser(model);


                if (result.Succeeded)
                {
                    return RedirectToAction("Login", "Account");
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(String.Empty, error.Description);
                }
            }
            return View(model);
        }
    }
}
