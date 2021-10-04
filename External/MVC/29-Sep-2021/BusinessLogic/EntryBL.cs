using DAL.Access;
using DAL.Migrations;
using DAL.Models;
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
        private readonly AccountDAL _accountDAL;

        public EntryBL(EntryDAL entryDAL, AccountDAL accountDAL)
        {
            this._entryDAL = entryDAL;
            this._accountDAL = accountDAL;
        }

        public List<Entry> GetEntry()
        {
            var entries = _entryDAL.GetEntry();

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

        public async Task<AspNetUser> GetUser(string name)
        {
            AspNetUser user = await _entryDAL.GetUser(name);

            return user;
        }
    }
}
