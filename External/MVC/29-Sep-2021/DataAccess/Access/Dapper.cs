using DAL.Models;
using DAL.Repository;
using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Access
{
    public class Dapper : IDapper
    {
        private readonly string _connectionString;

        public Dapper(string connectionString)
        {
            this._connectionString = connectionString;
        }

        //Get the Logged in user
        public AspNetUser GetUser(string name)
        {
            AspNetUser user = new();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {


                AspNetUser? aspNetUser = connection.Query<AspNetUser>("execute uspGetEmployee @mail", new { @mail = name }).FirstOrDefault();
                user = aspNetUser;
            }
            return user;
        }

        //Get Entries
        public List<Entry> GetEntry(string id)
        {
            List<Entry> entries = new();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                entries = connection.Query<Entry>("execute uspGetEntryByID @id", new { @id = id }).ToList();
            }

            return entries;
        }

        //Set Intime
        public void SetInTime(string time, string date, string id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Query("execute uspInsertEntry @date,@id,@intime", new { @date = date, @id = id, @intime = time });
            }
        }

        //Set Previous Entry
        public void SetEntry(Entry entry)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Query("execute uspInsertPeviousEntry @date,@id,@intime,@outtime", new { @date = entry.Date, @id = entry.EmployeeId, @intime = entry.InTime, @outtime = entry.OutTime });
            }
        }
    }
}
