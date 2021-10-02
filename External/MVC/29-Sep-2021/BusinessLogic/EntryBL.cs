using DAL.Access;
using Model.Model;
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
        public EntryBL(EntryDAL entryDAL)
        {
            this._entryDAL = entryDAL;
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
    }
}
