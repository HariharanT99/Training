using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL.Models;
using DAL.ViewModel;
using DAL.Interfaces;

namespace DataAccess.Access
{
    public class AccountDAL : IAccountDAL
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public AccountDAL(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, RoleManager<IdentityRole> roleManager)
        {
            this._userManager = userManager;
            this._signInManager = signInManager;
            this._roleManager = roleManager;
        }

        //Create User
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

        //Login Check User
        public async Task<SignInResult> CheckUser(Login model)
        {
            ApplicationUser user = await _userManager.FindByEmailAsync(model.Email);
            if (user != null)
            {
                var result = await _signInManager.PasswordSignInAsync(
                 user.Email, model.Password, model.RememberMe, false);

                return result;
            }

            var res = SignInResult.Failed;
            return res;
        }

        //GetUser
        public async Task<ApplicationUser> GetUser(string name)
        {
            ApplicationUser user = await _userManager.FindByNameAsync(name);

            return user;
        }

        //Create User
        public async Task<IdentityResult> CreateRole(CreateRoleViewModel model)
        {
            IdentityRole role = new IdentityRole
            {
                Name = model.RoleName
            };

            var result = await _roleManager.CreateAsync(role);

            return result;
        }
        //Get roles
        public List<IdentityRole> GetRoles()
        {
            var roles = _roleManager.Roles.ToList();

            return roles;
        }

        //Edit Role
        public async Task<EditRoleViewModel> EditRole(string id)
        {
            var role = await _roleManager.FindByIdAsync(id);

            if (role == null)
            {
                var emptymodel = new EditRoleViewModel
                {
                    Id = null
                };

                return emptymodel;
            }

            var model = new EditRoleViewModel
            {
                Id = role.Id,
                RoleName = role.Name
            };

            // Retrieve all the Users
            foreach (var user in _userManager.Users)
            {
                // If the user is in this role, add the username to
                // Users property of EditRoleViewModel. This model
                // object is then passed to the view for display
                if (await _userManager.IsInRoleAsync(user, role.Name))
                {
                    model.Users.Add(user.UserName);
                }
            }

            return model;
        }

        //Update Role
        public async Task<IdentityResult> UpdateRole(EditRoleViewModel model)
        {
            var role = await _roleManager.FindByIdAsync(model.Id);

            if (role == null)
            {
                var res = new IdentityResult();

                return res;
            }
            else
            {
                role.Name = model.RoleName;

                // Update the Role using UpdateAsync
                var result = await _roleManager.UpdateAsync(role);

                return result;

            }

        }

        //Add User to the Role
        public async Task<List<UserRoleViewModel>> EditUsersInRole(string roleId)
        {
            var role = await _roleManager.FindByIdAsync(roleId);

            var model = new List<UserRoleViewModel>();

            if (role == null)
            {
                var userRole = new UserRoleViewModel
                {
                    UserId = null
                };

                model.Add(userRole);

                return model;
            }


            foreach (var user in _userManager.Users)
            {
                var userRoleViewModel = new UserRoleViewModel
                {
                    UserId = user.Id,
                    UserName = user.UserName
                };

                if (await _userManager.IsInRoleAsync(user, role.Name))
                {
                    userRoleViewModel.IsSelected = true;
                }
                else
                {
                    userRoleViewModel.IsSelected = false;
                }

                model.Add(userRoleViewModel);
            }

            return model;
        }

        //Post User in the Role
        public async Task<bool> PostUsersInRole(List<UserRoleViewModel> model, string roleId)
        {
            var role = await _roleManager.FindByIdAsync(roleId);

            if (role == null)
            {

            }

            for (int i = 0; i < model.Count; i++)
            {
                var user = await _userManager.FindByIdAsync(model[i].UserId);

                IdentityResult result = null;

                if (model[i].IsSelected && !(await _userManager.IsInRoleAsync(user, role.Name)))
                {
                    result = await _userManager.AddToRoleAsync(user, role.Name);
                }
                else if (!model[i].IsSelected && await _userManager.IsInRoleAsync(user, role.Name))
                {
                    result = await _userManager.RemoveFromRoleAsync(user, role.Name);
                }
                else
                {
                    continue;
                }

                if (result.Succeeded)
                {
                    if (i < (model.Count - 1))
                        continue;
                    else
                        return true;
                }
            }
            return false;
        }

        //Delete Role
        public async Task<IdentityResult> DeleteRole(string id)
        {
            var role = await _roleManager.FindByIdAsync(id);

            if (role == null)
            {
                var res = new IdentityResult();
                return res;
            }
            else
            {
                var result = await _roleManager.DeleteAsync(role);

                return result;
            }
        }
    }
}
