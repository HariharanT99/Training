using DAL.Access;
using DAL.ViewModel;
using DataAccess.Access;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class AccountBL
    {
        private readonly NTireFacade _facade;
        public AccountBL(NTireFacade facade)
        {
            this._facade = facade;
        }

        //Create User
        public Task<IdentityResult> CreateUser(CreateEmployeeViewModel model)
        {
            var result = _facade.CreateUser(model);

            return result;
        }

        //Log in
        public Task<SignInResult> CheckUser(Login model)
        {
            var result = _facade.CheckUser(model);

            return result;
        }

        //Create Role
        public Task<IdentityResult> CreateRole(CreateRoleViewModel model)
        {
            var result = _facade.CreateRole(model);

            return result;
        }

        //Get Roles
        public List<IdentityRole> GetRoles()
        {
            var roles = _facade.GetRoles();

            return roles;
        }

        //Edit Role
        public Task<EditRoleViewModel> EditRole(string id)
        {
            var model = _facade.EditRole(id);

            return model;
        }

        //Update Role
        public Task<IdentityResult> UpdateRole(EditRoleViewModel model)
        {
            var role = _facade.UpdateRole(model);

            return role;
        }

        //Add User to the Roles
        public Task<List<UserRoleViewModel>> EditUsersInRole(string roleId)
        {
            var model = _facade.EditUsersInRole(roleId);

            return model;
        }

        //Set user to the roles
        public Task<bool> PostUsersInRole(List<UserRoleViewModel> model, string roleId)
        {
            var result = _facade.PostUsersInRole(model, roleId);

            return result;
        }

        //Delete Role
        public Task<IdentityResult> DeleteRole(string id)
        {
            var result = _facade.DeleteRole(id);

            return result;
        }
    }
}
