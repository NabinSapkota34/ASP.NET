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
        public ActionResult SaveData(employe employe)
        {
            db.employes.Add(employe);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}