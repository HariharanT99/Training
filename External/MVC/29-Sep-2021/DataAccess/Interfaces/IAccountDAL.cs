using Microsoft.AspNetCore.Identity;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.ViewModel;

namespace DAL.Interfaces
{
    public interface IAccountDAL
    {
        Task<IdentityResult> CreateUser(CreateEmployeeViewModel model);

        Task<SignInResult> CheckUser(Login model);

        Task<ApplicationUser> GetUser(string name);

        Task<IdentityResult> CreateRole(CreateRoleViewModel model);

        List<IdentityRole> GetRoles();

        Task<EditRoleViewModel> EditRole(string id);

        Task<IdentityResult> UpdateRole(EditRoleViewModel model);

        Task<List<UserRoleViewModel>> EditUsersInRole(string roleId);

        Task<bool> PostUsersInRole(List<UserRoleViewModel> model, string roleId);

        Task<IdentityResult> DeleteRole(string id);
    }
}
