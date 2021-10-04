using DAL.Access;
using DAL.Migrations;
using DAL.Models;
using DAL.Repository;
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
        public List<Entry> GetEntry(string id)
        {
            var entries = _facade.GetEntry(id);

            return entries;
        }

        public void SetEntry(Entry entry)
        {
            _entryDAL.SetEntry(entry);
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

    }
}
