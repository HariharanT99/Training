using Microsoft.AspNetCore.Identity;
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
        public AccountDAL(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            this._userManager = userManager;
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

    }
}
