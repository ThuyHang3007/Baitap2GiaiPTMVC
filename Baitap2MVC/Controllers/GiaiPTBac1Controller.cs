using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Baitap2MVC.Models;
namespace Baitap2MVC.Controllers
{
    public class GiaiPTBac1Controller : Controller
    {
        GiaiPTBac1 gpt = new GiaiPTBac1();

        // GET: GiaiPTBac1
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GiaiPTBac1()
        {
            return View();
        }

        [HttpPost]
        public ActionResult GiaiPTBac1(double hesoa, double hesob)
        {
            double x = gpt.GiaiPTBacMot(hesoa, hesob);
            ViewBag.nghiemPT = x;
            return View();
        }
    }
}
