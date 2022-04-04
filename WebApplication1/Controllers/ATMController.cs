using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ATMController : Controller
    {
        empEntities db = new empEntities();
        // GET: ATM
        public ActionResult Index()
        {
            List<salary_details> all_data = db.salary_details.ToList();
            return View(all_data);
        }
        public ActionResult Create()
        {
            return View();
        }
        public ActionResult Edit(int id)
        {
            salary_details data = db.salary_details.Find(id);
            return View(data);
        }
        public ActionResult SaveData(salary_details salary_details)
        {
            db.salary_details.Add(salary_details);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult UpdateData(salary_details salary_details)
        {
            salary_details update = db.salary_details.Find(salary_details.e_id);
            update.salary_paid = salary_details.salary_paid;
            update.paid_date = salary_details.paid_date;
            db.Entry(update).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult delete(int id)
        {
            salary_details data = db.salary_details.Find(id);
            return View(data);
        }
        public ActionResult DeleteData(salary_details salary_details)
        {
            salary_details delete = db.salary_details.Find(salary_details.e_id);
            db.salary_details.Remove(delete);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}