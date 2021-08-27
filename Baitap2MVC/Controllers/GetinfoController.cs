using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Baitap2MVC.Controllers
{
    public class GetinfoController : Controller
    {
        // GET: Getinfo
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Getinfo()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Getinfo(string Ten, string Tuoi, string Lop)
        {

            ViewBag.ten = Ten;
            ViewBag.tuoi = Tuoi;
            ViewBag.lop = Lop;

            return View();
        }
    }
}