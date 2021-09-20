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
        public IActionResult Feedback()
        {
            return View();
        }
        

        [HttpPost]
        public IActionResult Feedback(Feed feed)
        {
            return View();
        }
    }
}
