using DAL.Data;
using DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using DAL.ViewModel;
using System.Data;
using Dapper;
using DAL.Interfaces;
using DAL.DataViewModel;

namespace DAL.Access
{
    public class NTireFacade: INTireFacade
    {
        public readonly IAccountDAL _accountDAL;
        public readonly IEntryDAL _entryDAL;
        private readonly NTireAppContext _db;
        private readonly IDapper _dapper;

        public NTireFacade(IAccountDAL accountDAL, IEntryDAL entryDAL, NTireAppContext db, IDapper dapper)
        {
            this._accountDAL = accountDAL;
            this._entryDAL = entryDAL;
            this._db = db;
            this._dapper = dapper;
        }

        //Create User
        public Task<IdentityResult> CreateUser(CreateEmployeeViewModel model)
        {
            var result = _accountDAL.CreateUser(model);

            return result;
        }

        //Log in
        public Task<SignInResult> CheckUser(Login model)
        {
            var result = _accountDAL.CheckUser(model);

            return result;
        }

        //Create Role
        public Task<IdentityResult> CreateRole(CreateRoleViewModel model)
        {
            var result = _accountDAL.CreateRole(model);

            return result;
        }

        //Get Roles
        public List<IdentityRole> GetRoles()
        {
            var roles = _accountDAL.GetRoles();

            return roles;
        }

        //Edit Roles
        public Task<EditRoleViewModel> EditRole(string id)
        {
            var model = _accountDAL.EditRole(id);

            return model;
        }

        //Update Role
        public Task<IdentityResult> UpdateRole(EditRoleViewModel model)
        {
            var role = _accountDAL.UpdateRole(model);

            return role;
        }

        //Add User to the Roles
        public Task<List<UserRoleViewModel>> EditUsersInRole(string roleId)
        {
            var model = _accountDAL.EditUsersInRole(roleId);

            return model;
        }

        //Set user to the roles
        public Task<bool> PostUsersInRole(List<UserRoleViewModel> model, string roleId)
        {
            var result = _accountDAL.PostUsersInRole(model, roleId);

            return result;
        }


        //Delete Role
        public Task<IdentityResult> DeleteRole(string id)
        {
            var result = _accountDAL.DeleteRole(id);

            return result;
        }


        //Get Entries
        public List<EntryInptViewModel> GetEntry(string id, int? month)
        {
            List<EntryInptViewModel> entries = _dapper.GetEntry(id, month);

            return entries;
        }

        //Get the Logged in user
        public AspNetUser GetUser(string name)
        {
            var user = _dapper.GetUser(name);

            return user;
        }

        //Set Intime
        public void SetInTime(string time, string date, string id)
        {
            _dapper.SetInTime(time, date, id);
        }

        //Set Previous Entry
        public void SetEntry(Entry entry)
        {
            _dapper.SetEntry(entry);
        }

        //Get Entry by Date for Admin DashBoard
        public List<AdminDashboardViewModel> GetEmployeeEntry(DateTime? date)
        {
            var employeeEntry = _dapper.GetEmployeeEntry(date);

            return employeeEntry;
        }

        //Get Employees Present Today (Admin dashboard)
        public int PresentEmployeesCount()
        {
            var count = _dapper.PresentEmployeesCount();

            return count;
        }


        //Get Number of Active Employees (Admin Dashboard)
        public int ActiveEmployeesCount()
        {
            var activeCount = _dapper.ActiveEmployeesCount();

            return activeCount;
        }


        //Set Break (Current day entry)
        public void SetCurrentBreak(StartWorkViewModel model, string date, string workOffTime)
        {
            _dapper.SetCurrentBreak(model, date, workOffTime);
        }
    }
}
