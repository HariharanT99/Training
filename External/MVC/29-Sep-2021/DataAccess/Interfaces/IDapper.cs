﻿using DAL.DataViewModel;
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

        List<EntryInptViewModel> GetEntry(string id);

        void SetInTime(string time, string date, string id);

        void SetEntry(Entry entry);

        List<AdminDashboardViewModel> GetEmployeeEntry(DateTime date);

        int PresentEmployeesCount();
    }
}
