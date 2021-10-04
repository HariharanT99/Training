using BussinessObject.Model;
using Microsoft.AspNetCore.Identity;
using Model.ViewModel;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public interface IAccountDAL
    {
        Task<IdentityResult> CreateUser(CreateEmployeeViewModel model);

        Task<SignInResult> CheckUser(Login model);

        Task<ApplicationUser> GetUser(string name);
    }
}
