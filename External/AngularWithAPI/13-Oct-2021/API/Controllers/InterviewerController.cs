using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    public class InterviewerController : Controller
    {
        // GET: InterviewerController
        public ActionResult Index()
        {
            return View();
        }

        // GET: InterviewerController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: InterviewerController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: InterviewerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: InterviewerController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: InterviewerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: InterviewerController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: InterviewerController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
