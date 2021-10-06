﻿using BL;
using DAL.Models;
using DAL.ViewModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Presentation.Controllers
{
    public class AdministrationController : Controller
    {
        private readonly AccountBL _accountBL;
        public AdministrationController(AccountBL accountBL)
        {
            this._accountBL = accountBL;
        }
        public IActionResult CreateRole()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateRole(CreateRoleViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await _accountBL.CreateRole(model);

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

        //Get Roles
        public IActionResult GetRoles()
        {
            var roles = _accountBL.GetRoles();
            return View(roles);
        }

        //Edit Roles
        public async Task<IActionResult> EditRole(string id)
        {
            var model = await _accountBL.EditRole(id);

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> EditRole(EditRoleViewModel model)
        {
            var result = await _accountBL.UpdateRole(model);


            if (result.Succeeded)
            {
                return RedirectToAction("ListRoles");
            }

            foreach (var error in result.Errors)
            {
                ModelState.AddModelError("", error.Description);
            }

            return View(model);
        }
        
        public async Task<IActionResult> EditUserInRole(string roleId)
        {
            ViewBag.roleId = roleId;

            var model = await _accountBL.EditUsersInRole(roleId);

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> EditUserInRole(List<UserRoleViewModel> model, string roleId)
        {
            if (model.Any())
            {
                var result = await _accountBL.PostUsersInRole(model, roleId);

                if (result == true)
                {
                    return RedirectToAction("EditRole", new { Id = roleId });
                }
            }

            return RedirectToAction("EditRole", new { Id = roleId });
        }

    }
}
