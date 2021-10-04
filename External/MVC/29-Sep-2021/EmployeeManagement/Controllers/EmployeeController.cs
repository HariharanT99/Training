using BL;
using BusinessLogic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using DAL.Models;
using DAL.ViewModel;
using DAL.Migrations;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Presentation.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly EntryBL _entryBL;
        public EmployeeController(AccountBL accBL, EntryBL entryBL )
        {
            this._entryBL = entryBL;
        }

        [Authorize]
        public async Task<IActionResult> Index()
        {
            AspNetUser user = await _entryBL.GetUser(User.Identity.Name);
            return View(user);
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

        public IActionResult Dashboard()
        {
            IEnumerable<Entry> entries = new List<Entry>(2);
            return View(entries);
        }
    }
}
