using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class nabinController : Controller
    {
        empEntities db = new empEntities();
        // GET: nabin
        public ActionResult index()
        {
            List<employe> all_data = db.employes.ToList();
            return View(all_data);
        }
        public ActionResult Create()
        {
            return View();
        }
        public ActionResult Edit(int id)
        {
            employe data=db.employes.Find(id);
            return View(data);
        }
        public ActionResult SaveData(employe employe)
        {
            db.employes.Add(employe);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult UpdateData(employe employe)
        {
            employe update = db.employes.Find(employe.e_id);
            update.e_name= employe.e_name;
            update.salary= employe.salary;
            db.Entry(update).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult delete(int id)
        {
            employe data = db.employes.Find(id);
            return View(data);
        }
        public ActionResult DeleteData(employe employe)
        {
            employe delete = db.employes.Find(employe.e_id);
            db.employes.Remove(delete);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}