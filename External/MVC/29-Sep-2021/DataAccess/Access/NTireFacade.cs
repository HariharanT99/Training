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

        //Get Entries
        public List<Entry> GetEntry(string id)
        {
            SqlParameter pId = new SqlParameter("@Id", id);
            var entries = _db.Entries.FromSqlRaw($"select Date, InTime, OutTime from Entry where Id = @Id", pId).ToList();

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
            var existingUser = _db.AspNetUsers.FromSqlRaw($"select * from aspnetusers where Email = @Email", pName).FirstOrDefault();
            return existingUser;
        }

        //Set Intime
        public void SetInTime(string time, string date, string id)
        {
            SqlParameter pTime = new SqlParameter("@Date", date);
            SqlParameter pDate = new SqlParameter("@Id", id);
            SqlParameter pId = new SqlParameter("@Intime", time);

            _db.AspNetUsers.FromSqlRaw($"EXEC uspInsertEntry @Date,@Id,@Intime", date, id, time);
        }
    }
}
