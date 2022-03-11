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
        public ActionResult Index()
        {
            List<nabin> all_data = db.nabins.ToList();
            return View(all_data);
        }
    }
}