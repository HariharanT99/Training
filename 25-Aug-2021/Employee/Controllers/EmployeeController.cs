using EmployeeProject.Data;
using EmployeeProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeProject.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ApplicationDbContext _dbObj;
        public EmployeeController(ApplicationDbContext dbObj)
        {
            _dbObj = dbObj;
        }

        public IActionResult Index()
        {
            var employeesList = from employees in _dbObj.Employees where employees.StatusActive == true select employees;
            //IEnumerable<Employee> employeesList = _dbObj.Employees;

            return View(employeesList);
        }

        public IActionResult InActive()
        {
            var employeesList = from employees in _dbObj.Employees where employees.StatusActive == false select employees;
            //IEnumerable<Employee> employeesList = _dbObj.Employees;

            return View(employeesList);
        }

        public IActionResult Status(int? id)
        {
            var employeeObj = _dbObj.Employees.Find(id);
            var employee = new Employee
            {
                EmployeeId = employeeObj.EmployeeId,
                Name = employeeObj.Name,
                Designation = employeeObj.Designation,
                DepartmentId = employeeObj.DepartmentId,
                HireDate = employeeObj.HireDate,
                StatusActive = !employeeObj.StatusActive
            };
            if (ModelState.IsValid)
            {
                _dbObj.Employees.Remove(employeeObj);
                _dbObj.Employees.Update(employee);
                _dbObj.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(employeeObj);
        }

        public IActionResult Create()
        {
            IEnumerable<SelectListItem> myDepartments = _dbObj.Departments.Select(x=> 
                new SelectListItem
                {
                    Text = x.DepartmentId.ToString(),
                    Value =  x.DepartmentId.ToString()
                });

            ViewBag.deptIdDropdown = myDepartments;

            return View();
        }

        [HttpPost]
        public IActionResult Create(Employee employeeObj)
        {
            if (ModelState.IsValid)
            {
                _dbObj.Employees.Add(employeeObj);
                _dbObj.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(employeeObj);
        }

        public IActionResult Update(int? id)
        {
            IEnumerable<SelectListItem> myDepartments = _dbObj.Departments.Select(x=> 
                new SelectListItem
                {
                    Text = x.DepartmentId.ToString(),
                    Value =  x.DepartmentId.ToString()
                });

            ViewBag.deptIdDropdown = myDepartments;

            if (id == null)
            {
                return NotFound();
            }

            var employee = _dbObj.Employees.FirstOrDefault(x => x.EmployeeId == id);
            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);

        }

        [HttpPost]
        public IActionResult Update(Employee employee)
        {
            if (ModelState.IsValid)
            {
                _dbObj.Employees.Update(employee);
                _dbObj.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(employee);

        }

        public IActionResult Delete(int? id)
        {
            var employeeObj = _dbObj.Employees.Find(id);
            if (employeeObj == null)
            {
                return NotFound();
            }

            _dbObj.Employees.Remove(employeeObj);
            _dbObj.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
