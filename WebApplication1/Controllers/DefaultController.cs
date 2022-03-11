using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class DefaultController : Controller
    {
        empEntities db = new empEntities();
        // GET: Default
        public ActionResult Services()
        {
            List<employe> all_data = db.employes.ToList();
            return View(all_data);
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your page is";
            return View();
        }
    }
}