using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccess.Access;
using Microsoft.AspNetCore.Identity;
using DAL.Models;
using DAL.ViewModel;
using BL;

namespace EmployeeManagement.Controllers
{
    public class AccountController : Controller
    {
        private readonly AccountBL _accountBL;

        private readonly SignInManager<ApplicationUser> _signInManager;
        public AccountController(AccountBL accountBL, SignInManager<ApplicationUser> signInManager)
        {
            this._accountBL = accountBL;
            this._signInManager = signInManager;
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(Login model)
        {
            if (ModelState.IsValid)
            {
                var result = await _accountBL.CheckUser(model);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Employee",result);
                }

                ModelState.AddModelError(string.Empty, "Invalid Login Attempt");
            }
            return View(model);
        }

        public IActionResult CreateEmployee()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateEmployee(CreateEmployeeViewModel model)
        {
            if (ModelState.IsValid)
            {

                var result = await _accountBL.CreateUser(model);

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


        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();

            return RedirectToAction("Login", "Account");
        }
    }
}
