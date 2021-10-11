using DAL.Access;
using DAL.DataViewModel;
using DAL.Migrations;
using DAL.Models;
using DAL.ViewModel;
using DataAccess.Access;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class EntryBL
    {
        private readonly EntryDAL _entryDAL;
        private readonly NTireFacade _facade;

        public EntryBL(EntryDAL entryDAL, NTireFacade facade)
        {
            this._entryDAL = entryDAL;
            this._facade = facade;
        }


        //Get Entries
        public List<EntryInptViewModel> GetEntry(string id, int? month)
        {
            var entries = _facade.GetEntry(id, month);

            return entries;
        }
        
        //Set Previous Entry
        public void SetEntry(EntryViewModel model)
        {
            Entry entry = new Entry
            {
                Id = model.Id,
                EmployeeId = model.EmployeeId,
                Date = model.Date,
                InTime = model.InTime,
                OutTime = model.OutTime,
                Breaks = model.BreakList,
                
            };

            _facade.SetEntry(entry);
        }

        public void SetBreak(IList<Break> brk)
        {
            _entryDAL.SetBreak(brk);
        }

        public async Task<AspNetUser> GetUsers(string name)
        {
            AspNetUser user = await _entryDAL.GetUser(name);

            return user;
        }

        //Get the logged in user
        public AspNetUser GetUser(string name)
        {
            return _facade.GetUser(name);
        }

        //Set the InTime
        public void SetInTime(string time, string date, string id)
        {
            _facade.SetInTime(time, date, id);
        }

        //Get Entry by Date for Admin DashBoard
        public List<AdminDashboardViewModel> GetEmployeeEntry(DateTime? date)
        {
            var employeeEntry = _facade.GetEmployeeEntry(date);

            return employeeEntry;
        }

        //Get Employees Present Today (Admin dashboard)
        public int PresentEmployeesCount()
        {
            var count = _facade.PresentEmployeesCount();

            return count;
        }

        //Set Break (Current day entry)
        public void SetCurrentBreak(StartWorkViewModel model, string date, string workOffTime)
        {
            _facade.SetCurrentBreak(model, date, workOffTime);
        }

    }
}
