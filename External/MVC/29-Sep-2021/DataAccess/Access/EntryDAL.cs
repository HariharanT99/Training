using Model.Data;
using Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Access
{
    public class EntryDAL
    {
        private readonly ThreeTierContext _db;
        public EntryDAL(ThreeTierContext db)
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
    }
}
