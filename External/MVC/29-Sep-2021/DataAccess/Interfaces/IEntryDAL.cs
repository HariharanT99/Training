using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IEntryDAL
    {
        List<Entry> GetEntry();

        void SetEntry(Entry entry);

        void SetBreak(IList<Break> brks);
        Task<AspNetUser> GetUser(string name);
    }
}
