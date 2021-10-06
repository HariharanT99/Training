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
    [Authorize(Roles = "Employee,Admin")]
    public class EmployeeController : Controller
    {
        private readonly EntryBL _entryBL;
        public EmployeeController(AccountBL accBL, EntryBL entryBL )
        {
            this._entryBL = entryBL;
        }

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

            ViewBag.User = _entryBL.GetUser(User.Identity.Name);
            return View(entry);
        }

        [HttpPost]
        public IActionResult CreateEntry(EntryViewModel model)
        {
            var breakList = model.BreakList;

            _entryBL.SetBreak(breakList);

            _entryBL.SetEntry(model);

            return RedirectToAction("Index", "Employee");
        }

        [Authorize(Roles = "Employee")]
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

        [Authorize(Roles ="Admin")]
        public IActionResult AdminDashboard(string id)
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
