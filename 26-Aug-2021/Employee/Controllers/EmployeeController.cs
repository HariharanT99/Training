using EmployeeProject.Data;
using EmployeeProject.Models;
using EmployeeProject.ViewModel;
using FluentNHibernate.Conventions.Inspections;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeProject.Controllers
{
    public class EmployeeController : BaseController<Employee>
    {
        private readonly ApplicationDbContext _dbObj;
        public EmployeeController(ApplicationDbContext dbObj)
        {
            _dbObj = dbObj;
        }

        public IActionResult Index(string sortOrder, string search, int page = 1)
        {
            var employeesList = _dbObj.Employees.Include("Dept").Where(e => e.StatusActive == true);


            ViewData["EmpIdSortAsc"] = sortOrder == "EmployeeId" ? "empId_desc" : "empId_asc";
            ViewData["EmpIdSortDesc"] = sortOrder == "EmployeeId" ? "empId_asc" : "empId_desc";
            ViewData["EmpNameSortAsc"] = sortOrder == "Name" ? "name_desc" : "name_asc";
            ViewData["EmpNameSortDesc"] = sortOrder == "Name" ? "name_asc" : "name_desc";
            ViewData["DeptIdSortDesc"] = sortOrder == "DepartmentId" ? "deptId_desc" : "deptId_asc";
            ViewData["DeptIdSortDesc"] = sortOrder == "DepartmentId" ? "deptId_asc" : "deptId_desc";

            if (!string.IsNullOrEmpty(search))
            {
                employeesList = employeesList.Where(x => x.Name.ToLower().
                    Contains(search.ToLower()));
            }

            switch (sortOrder)
            {
                case "empId_asc":
                    employeesList = employeesList.OrderBy(x => x.EmployeeId);
                    break;
                case "empId_desc":
                    employeesList = employeesList.OrderByDescending(x => x.EmployeeId);
                    break;
                case "name_asc":
                    employeesList = employeesList.OrderBy(x => x.Name);
                    break;
                case "name_desc":
                    employeesList = employeesList.OrderByDescending(x => x.Name);
                    break;
                case "deptId_asc":
                    employeesList = employeesList.OrderBy(x => x.DepartmentId);
                    break;
                case "deptId_desc":
                    employeesList = employeesList.OrderByDescending(x => x.DepartmentId);
                    break;
                default:
                    break;
            }
            var paginatedResult = PaginatedResult(employeesList.ToList(), page, 5);

            //dynamic obj = new ExpandoObject();

            //obj.empList = paginatedResult;

            //ViewBag.Data = obj;

            return View(paginatedResult);
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
