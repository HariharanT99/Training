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

        //Get Entries
        public List<EntryInptViewModel> GetEntry(string id)
        {
            List<EntryInptViewModel> entries = _dapper.GetEntry(id);

            return entries;
        }

        //Get the Logged in user
        public AspNetUser GetUser(string name)
        {
            var user = _dapper.GetUser(name);

            return user;
        }


        //Get the Logged in user
        //        public AspNetUser GetUser(string name)
        //        {

        //            AspNetUser user = new();

        //            using (SqlConnection connection = new SqlConnection(""))
        //            {
        //                AspNetUser? aspNetUser = connection.Query<AspNetUser>($"EXEC EXECUTE uspGetEmployee @Email= {name}").FirstOrDefault();
        //                user = aspNetUser;


        //                //SqlCommand cmd = new SqlCommand();
        //                //cmd.Connection = cnn;
        //                //cmd.CommandType = CommandType.Text;
        //                //cmd.CommandText = $"EXECUTE uspGetEmployee {name}";

        //                //cnn.Open();

        //                //SqlDataReader reader = cmd.ExecuteReader();

        //                //AspNetUser user = new AspNetUser();

        //                //user.Id = reader.GetString(0);
        //                //user.Name = reader.GetString(1);
        //                //user.Email = reader.GetString(2);
        //                //user.Gender = reader.GetString(3);
        //                //user.DateOfBirth = reader.GetDateTime(4);
        //                //user.Address = reader.GetString(5);
        //            }

        //#pragma warning disable CS8603 // Possible null reference return.
        //            return user;
        //#pragma warning restore CS8603 // Possible null reference return.

        //            //SqlParameter pName = new SqlParameter("@Email", name);

        //            //var user = AspNetUsers.FromSqlRaw<AspNetUser>("EXECUTE uspGetEmployee @Email").FirstOrDefault();
        //            //var users = AspNetUsers.FromSqlRaw("uspGetEmployee @Email", pName).ToList();

        //            //SqlParameter pName = new SqlParameter("@Email", name);
        //            //AspNetUser existingUser = _db.AspNetUsers.FromSqlRaw("Select * from aspnetusers Where Email = @Email", pName).FirstOrDefault();
        //            //return existingUser;
        //        }

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
        public List<AdminDashboardViewModel> GetEmployeeEntry(DateTime date)
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
    }
}
