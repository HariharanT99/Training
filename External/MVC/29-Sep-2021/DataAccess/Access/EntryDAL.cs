using DAL.Data;
using DAL.Interfaces;
using DAL.Migrations;
using DAL.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Access
{
    public class EntryDAL: IEntryDAL
    {
        private readonly NTireAppContext _db;
        public EntryDAL(NTireAppContext db)
        {
            this._db = db;
        }

        public List<Entry> GetEntry()
        {
            var entries = _db.Entries.ToList();

            return entries;
        }

        public void SetEntry(Entry entry)
        {
            _db.Entries.Add(entry);
        }

        public void SetBreak(IList<Break> brks)
        {

            foreach (var brk in brks)
            {
                _db.Breaks.Add(brk);
            }
        }

        public async Task<AspNetUser> GetUser(string name)
        {
            AspNetUser user = await _db.AspNetUsers.FindAsync(name);

            return user;
        }
    }
}
