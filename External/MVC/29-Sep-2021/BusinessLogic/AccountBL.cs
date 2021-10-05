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
    }
}
