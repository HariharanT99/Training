using EmployeeProject.Data;
using EmployeeProject.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeProject.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly ApplicationDbContext _dbObj;
        public DepartmentController(ApplicationDbContext dbObj)
        {
            _dbObj = dbObj;
        }


        [Authorize]
        public IActionResult Index()
        {
            IEnumerable<Department> departments = _dbObj.Departments;
            return View(departments);
        }

        public IActionResult Create()
        {
            return View();
        }


        [Authorize]
        [HttpPost]
        public IActionResult Create(Department departmentObj)
        {
            if (ModelState.IsValid)
            {
                _dbObj.Departments.Add(departmentObj);
                _dbObj.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(departmentObj);
        }
    }
}