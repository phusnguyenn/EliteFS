using EliteFS.EliteModels;
using EliteFS.Models;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EliteFS.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        EliteDbContext db = new EliteDbContext();

        public ActionResult Index()
        {
            return View();
        }
    }
}