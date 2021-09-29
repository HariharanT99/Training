using BussinessObject.Model;
using DataAccess.Access;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class AccountBL
    {
        private readonly AccountDAL _accountDAL;
        public AccountBL( AccountDAL accountDAL)
        {
            this._accountDAL = accountDAL;
        }
        public Task<IdentityResult> CreateUser(Register model)
        {
            var result = _accountDAL.CreateUser(model);
            return result;
        }

        public Task<SignInResult> CheckUser(Login model)
        {
            var result = _accountDAL.CheckUser(model);

            return result;
        }
    }
}
