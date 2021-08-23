using BankProject.Data;
using BankProject.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankProject.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ApplicationDbContext _bankObj;

        public CustomerController(ApplicationDbContext bankObj)
        {
            this._bankObj = bankObj;
        } 
        public IActionResult Index()
        {
            IEnumerable<Customer> customers = _bankObj.Customers;

            return View(customers);
        }

        public IActionResult AddCustomer()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddCustomer(Customer customerObj)
        {
            if (ModelState.IsValid)
            {
                _bankObj.Customers.Add(customerObj);
                _bankObj.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(customerObj);
        }
    }
}
