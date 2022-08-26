using EmployeeMgtSystem.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmployeeMgtSystem.Controllers
{
    public class EmployeesController : Controller
    {

        EMSDb_2Entities1 db = new EMSDb_2Entities1();

        // GET: Employees
        public ActionResult Index()
        {
            var employeeList = db.Employeestbs.ToList();
            return View(employeeList);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Employeestb employeestb)
        {
            if (ModelState.IsValid)
            {
                db.Employeestbs.Add(employeestb);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(employeestb);
        }

        public ActionResult Edit(int Id)
        {
            var employee = db.Employeestbs.Where(x => x.Id == Id).FirstOrDefault();
            return View(employee);
        }

        [HttpPost]
        public ActionResult Edit(Employeestb employeestb)
        {
            if (ModelState.IsValid)
            {
                db.Employeestbs.Attach(employeestb);
                db.Entry(employeestb).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(employeestb);
        }

        [HttpPost]
        public ActionResult Delete (int Id)
        {
            Employeestb employee = db.Employeestbs.Find(Id);
                    
            db.Employeestbs.Remove(employee);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}