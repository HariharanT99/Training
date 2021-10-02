using BL;
using BusinessLogic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Model.Data;
using Model.Model;
using Model.ViewModel;

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
        public IActionResult Index()
        {
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
    }
}
