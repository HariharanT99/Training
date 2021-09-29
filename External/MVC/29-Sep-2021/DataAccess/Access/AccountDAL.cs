﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BussinessObject.Model;

namespace DataAccess.Access
{
    public class AccountDAL
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public AccountDAL(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            this._userManager = userManager;
            this._signInManager = signInManager;
        }

        public async Task<IdentityResult> CreateUser(Register model)
        {
            var user = new IdentityUser
            {
                UserName = model.Email,
                Email = model.Email
            };

            var result = await _userManager.CreateAsync(user, model.Password);
            return result;
        }

        public async Task<SignInResult> CheckUser(Login model)
        {
            var user = await _userManager.FindByEmailAsync(model.Email);
            if (user != null)
            {
                var result = await _signInManager.PasswordSignInAsync(
                 user.Email, model.Password, model.RememberMe, false);

                return result;
            }

            var res = SignInResult.Failed;
            return res;
        }
    }
}
