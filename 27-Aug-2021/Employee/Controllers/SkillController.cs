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
    public class SkillController : Controller
    {

        private readonly ApplicationDbContext _dbObj;
        public SkillController(ApplicationDbContext dbObj)
        {
            _dbObj = dbObj;
        }
        public IActionResult Index()
        {
            IEnumerable<Skill> skills = _dbObj.Skills;
            return View(skills);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Skill skillObj)
        {
            var skillset = (from x in _dbObj.Skills
                            where x.SkillName.ToLower() == skillObj.SkillName.ToLower()
                            select x).ToList();

            if (ModelState.IsValid)
            {
                if ( skillset.Count > 0)
                {
                    ViewBag.Duplicate = "Skill " + skillObj.SkillName + " is already exist.";
                }
                else
                {
                    _dbObj.Skills.Add(skillObj);
                    _dbObj.SaveChanges();

                    return RedirectToAction("Index");
                }
            }

            return View(skillObj);
        }

        public IActionResult Update(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var skill = _dbObj.Skills.FirstOrDefault(x => x.SkillId == id);
            if (skill == null)
            {
                return NotFound();
            }

            return View(skill);

        }

        [HttpPost]
        public IActionResult Update(Skill skill)
        {
            if (ModelState.IsValid)
            {
                _dbObj.Skills.Update(skill);
                _dbObj.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(skill);

        }

        public IActionResult Delete(int? id)
        {
            var skillObj = _dbObj.Skills.Find(id);
            if (skillObj == null)
            {
                return NotFound();
            }

            _dbObj.Skills.Remove(skillObj);
            _dbObj.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
