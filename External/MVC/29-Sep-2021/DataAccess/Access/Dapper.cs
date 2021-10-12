using DAL.DataViewModel;
using DAL.Interfaces;
using DAL.Models;
using DAL.ViewModel;
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

        private readonly SqlConnection _connection;

        public Dapper(string connectionString)
        {
            this._connectionString = connectionString;
            this._connection = new SqlConnection(connectionString);
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
        public List<EntryInptViewModel> GetEntry(string id, int? month)
        {
            List<EntryInptViewModel> entries = new();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                entries = connection.Query<EntryInptViewModel>("execute uspGetEntryByID @id, @Month", new { @id = id, @Month = month }).ToList();
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

                var entryId = connection.Query<Entry>("execute uspGetEntryByID_Date @Id,@Date", new { @Id = entry.EmployeeId, @Date = entry.Date }).FirstOrDefault();

                foreach (var brk in entry.Breaks)
                {
                    connection.Query("execute uspSetFormBreak @EntryId,@BreakIn,@BreakOut", new { @EntryId = entryId.Id, @BreakIn = brk.BreakIn, @BreakOut = brk.BreakOut });
                }
            }
        }

        //Get Entry by Date (Admin dashboard)
        public List<AdminDashboardViewModel> GetEmployeeEntry(DateTime? date)
        {
            List < AdminDashboardViewModel > employeeentry = new();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                employeeentry = connection.Query<AdminDashboardViewModel>("execute uspGetEmployeesByDate @date", new { @date = date }).ToList();
            }

            return employeeentry;
        }

        //Get Employees Present Today (Admin dashboard)
        public int PresentEmployeesCount()
        {
            int count;
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                count = connection.Query<int>("execute uspEmployeePresentToday").FirstOrDefault();
            }

            return count;
        }


        //Get Number of Active Employees (Admin Dashboard)
        public int ActiveEmployeesCount()
        {
            int activeCount;
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                activeCount = connection.Query<int>("execute uspGetActiveEmployee").FirstOrDefault();
            }

            return activeCount;
        }


        //Set Break (Current day entry)
        public void SetCurrentBreak(StartWorkViewModel model,string date,string workOffTime)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Query("execute uspSetWorkOff @WorkOff,@Emp_Id,@Date", new { @WorkOff = workOffTime, @Emp_Id = model.EmployeeId, @Date = date });

                var entryId = connection.Query<int>("execute uspGetEntryByID_Date @Id,@Date", new { @Id = model.EmployeeId, @Date = date }).FirstOrDefault();

                foreach (var brk in model.BreakList)
                {
                    if (brk.BreakIn != null)
                    {
                        connection.Query("execute uspSetFormBreak @EntryId,@BreakIn,@BreakOut", new { @EntryId = entryId, @BreakIn = brk.BreakIn, @BreakOut = brk.BreakOut });
                    }
                }
            }
        }
    }
}
