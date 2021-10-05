using BL;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using DAL.Models;
using DAL.ViewModel;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using System;

namespace Presentation.Controllers
{
    public class EmployeeController : Controller
    {
        //private string _id;
        private readonly EntryBL _entryBL;
        public EmployeeController(AccountBL accBL, EntryBL entryBL )
        {
            this._entryBL = entryBL;
        }

        [Authorize]
        public IActionResult Index()
        {
            AspNetUser user = _entryBL.GetUser(User.Identity.Name);
            return View(user);
        }

        public IActionResult StartWork(string id)
        {
            var time = DateTime.Now.ToString("HH:mm:ss");
            var date = DateTime.Now.ToString("yyyy-MM-dd");
            _entryBL.SetInTime(time, date, id);
            return View();
        }
        public IActionResult CreateEntry()
        {
            EntryViewModel entry = new EntryViewModel();
            entry.BreakList.Add(new Break() { EntryId = 1 });
            return View(entry);
        }

        [HttpPost]
        public IActionResult CreateEntry(EntryViewModel model)
        {
            var breakList = model.BreakList;

            _entryBL.SetBreak(breakList);

            Entry entry = new Entry
            {
                Date = model.Date,
                InTime = model.InTime,
                OutTime = model.OutTime,
            };

            _entryBL.SetEntry(entry);

            return View("Index");
        }

        public IActionResult Dashboard(string id)
        {
            if (id != null)
            {
                var entries = _entryBL.GetEntry(id);

                return View(entries);
            }

            ViewBag.ErrorMessage = "Id Should not be null";

            return View();
        }
    }
}
