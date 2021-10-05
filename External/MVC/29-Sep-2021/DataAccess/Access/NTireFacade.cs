using DAL.Data;
using DAL.Models;
using DAL.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using DAL.ViewModel;

namespace DAL.Access
{
    public class NTireFacade: INTireFacade
    {
        public readonly IAccountDAL _accountDAL;
        public readonly IEntryDAL _entryDAL;
        private readonly NTireAppContext _db;
        public NTireFacade(IAccountDAL accountDAL, IEntryDAL entryDAL, NTireAppContext db)
        {
            this._accountDAL = accountDAL;
            this._entryDAL = entryDAL;
            this._db = db;
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


        //Get Entries
        public List<Entry> GetEntry(string id)
        {
            SqlParameter pId = new SqlParameter("@Id", id);
#nullable enable
            List<Entry> entries = _db.Entries.FromSqlRaw($"select * from Entry where EmployeeId = @Id", pId).ToList();
            //List<Entry> entries = new List<Entry>();
            //entries.Add(entry);

            return entries;
        }

        //Get the Logged in user
        public AspNetUser GetUser(string name)
        {
            //using (SqlConnection cnn = new SqlConnection("Server = TRAINEE - 05; Database = NTireApp; User Id = SA; Password = harant@26031999"))
            //{
            //    SqlCommand cmd = new SqlCommand();
            //    cmd.Connection = cnn;
            //    cmd.CommandType = CommandType.Text;
            //    cmd.CommandText = $"EXECUTE uspGetEmployee @Email = {pName}";

            //    cnn.Open();

            //    SqlDataReader reader = cmd.ExecuteReader();

            //    AspNetUser user = new AspNetUser();

            //    user.Id = reader.GetString(0);
            //    user.Name = reader.GetString(1);
            //    user.Email = reader.GetString(2);
            //    user.Gender = reader.GetString(3);
            //    user.DateOfBirth = reader.GetDateTime(4);
            //    user.Address = reader.GetString(5);

            //    return user;
            //}




            //SqlParameter pName = new SqlParameter("@Email", name);
            //var user = AspNetUsers.FromSqlRaw<AspNetUser>("EXECUTE uspGetEmployee @Email").FirstOrDefault();
            //var users = AspNetUsers.FromSqlRaw("uspGetEmployee @Email", pName).ToList();

            SqlParameter pName = new SqlParameter("@Email", name);
            AspNetUser existingUser = _db.AspNetUsers.FromSqlRaw("Select * from aspnetusers Where Email = @Email", pName).FirstOrDefault();
            return existingUser;
        }

        //Set Intime
        public void SetInTime(string time, string date, string id)
        {
            SqlParameter pDate = new SqlParameter("@Date", date);
            SqlParameter pInTime = new SqlParameter("@Intime", time);
            SqlParameter pId = new SqlParameter("@Id", id);

            _db.AspNetUsers.FromSqlRaw("EXEC uspInsertEntry @Date,@Id,@Intime", pDate, pId, pInTime);
        }

        //Set Previous Entry
        public void SetEntry(Entry entry)
        {
            SqlParameter pDate = new SqlParameter("@Date", entry.Date);
            SqlParameter pId = new SqlParameter("@Id", entry.EmployeeId);
            SqlParameter pInTime = new SqlParameter("@Intime", entry.InTime);
            SqlParameter pOutTime = new SqlParameter("@Intime", entry.OutTime);
            _db.Entries.FromSqlRaw("EXEC uspInsertPeviousEntry @Date, @Id, @InTime, @OutTime", pDate, pId, pInTime, pOutTime);
        }
    }
}
