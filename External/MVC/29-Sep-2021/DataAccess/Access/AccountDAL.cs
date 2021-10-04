using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL.Models;
using DAL.Repository;
using DAL.ViewModel;

namespace DataAccess.Access
{
    public class AccountDAL: IAccountDAL
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public AccountDAL(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            this._userManager = userManager;
            this._signInManager = signInManager;
        }

        public async Task<IdentityResult> CreateUser(CreateEmployeeViewModel model)
        {
            var user = new ApplicationUser
            {
                UserName = model.Email,
                Email = model.Email,
                Name = model.Name,
                Gender = model.Gender,
                DateOfBirth = model.DateOfBirth,
                Address = model.Address
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

        public async Task<ApplicationUser> GetUser(string name)
        {
            ApplicationUser user = await _userManager.FindByNameAsync(name);

            return user;
        }
    }
}
