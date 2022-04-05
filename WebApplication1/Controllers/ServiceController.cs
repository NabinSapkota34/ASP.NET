using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ServiceController : Controller
    {
        empEntities db = new empEntities();
        // GET: Service
        public ActionResult Index()
        {
            List<nabin> all_data = db.nabins.ToList();
            return View(all_data);
        }
        public ActionResult Create()
        {
            var empList = db.nabins.ToList();
            ViewBag.employeeList = new SelectList(empList, "e_id", "e_name");
            return View();
        }
        public ActionResult Edit(int id)
        {
            nabin data = db.nabins.Find(id);
            return View(data);
        }
        public ActionResult SaveData(nabin nabin)
        {
            db.nabins.Add(nabin);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult UpdateData(nabin nabin)
        {
            nabin update = db.nabins.Find(nabin.e_id);
            update.e_name = nabin.e_name;
            update.salary = nabin.salary;
            db.Entry(update).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult delete(int id)
        {
            nabin data = db.nabins.Find(id);
            return View(data);
        }
        public ActionResult DeleteData(nabin nabin)
        {
            nabin delete = db.nabins.Find(nabin.e_id);
            db.nabins.Remove(delete);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
