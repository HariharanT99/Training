using Identity.Data;
using Identity.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Identity.Controllers
{
    public class FeedController : Controller
    {
        private readonly AppDbContext _dbObj;
        public FeedController(AppDbContext dbObj)
        {
            _dbObj = dbObj;
        }


        public IActionResult Feedback()
        {
            return View();
        }
        

        [HttpPost]
        public IActionResult Feedback(Feed feed)
        {
            if (ModelState.IsValid)
            {
                _dbObj.Feedbacks.Add(feed);
                _dbObj.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(feed);
        }
    }
}
