using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IDapper
    {
        AspNetUser GetUser(string name);

        List<Entry> GetEntry(string id);

        void SetInTime(string time, string date, string id);

        void SetEntry(Entry entry);
    }
}
