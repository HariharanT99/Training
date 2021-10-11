using BL;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using DAL.Models;
using DAL.ViewModel;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using System;
using DAL.DataViewModel;

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


        //Index
        public IActionResult Index()
        {
            AspNetUser user = _entryBL.GetUser(User.Identity.Name);
            return View(user);
        }


        //Start work for Current Day
        public IActionResult StartWork(string id)
        {
            var time = DateTime.Now.ToString("HH:mm:ss");
            var date = DateTime.Now.ToString("yyyy-MM-dd");
            _entryBL.SetInTime(time, date, id);
            ViewBag.UserId = id;

            StartWorkViewModel entry = new();
            entry.BreakList.Add(new BreakViewModel() { Id = 1 });

            return View(entry);
        }

        [HttpPost]
        public IActionResult StartWork(StartWorkViewModel model)
        {
            var workOffTime = DateTime.Now.ToString("H:mm:ss");
            var date = DateTime.Now.ToString("yyyy-MM-dd");

            _entryBL.SetCurrentBreak(model, date, workOffTime);

            return RedirectToAction("Index", "Employee");
        }


        // Create Entry for Previous Day
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
            //var breakList = model.BreakList;

            //_entryBL.SetBreak(breakList);

            _entryBL.SetEntry(model);

            return RedirectToAction("Index", "Employee");
        }


        //Dashboard
        [Authorize(Roles = "Employee")]
        [HttpGet]
        public IActionResult Dashboard(string id, DashboardMonthViewModel? model)
        {
            ViewBag.Id = id;

            if (id != null )
            {
                var entries = _entryBL.GetEntry(id, model.Month);
                ViewBag.Count = entries.Count;
                ViewBag.Entries = entries;
                return View();
            }

            ViewBag.ErrorMessage = "Id Should not be null";

            List<EntryInptViewModel> ent = new();
            ViewBag.Entries = ent;
            return View();
        }

        [Authorize(Roles ="Admin")]
        [HttpGet]
        public IActionResult AdminDashboard(DashboardMonthViewModel? model)
        {

            var employeeEntry = _entryBL.GetEmployeeEntry(model.Date);
            ViewBag.Entries = employeeEntry;
            ViewBag.EntriesCount = employeeEntry.Count;

            ViewBag.Count = _entryBL.PresentEmployeesCount();

            ViewBag.ActiveEmployeesCount = _entryBL.ActiveEmployeesCount();

            return View();
        }


    }
}
