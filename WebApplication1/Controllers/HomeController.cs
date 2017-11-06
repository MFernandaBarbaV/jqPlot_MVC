using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PieRenderer()
        {
            return View();
        }

        public JsonResult GetPieRenderer()
        {
            EntitiesDeviceDomainCore db = new EntitiesDeviceDomainCore();
            var DbResult = from d in db.CypherKey
                           select new
                           {
                               d.SerialNumber,
                               d.RemainingFolios
                           };

            return Json(DbResult, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetChartRenderer()
        {
            EntitiesDeviceDomainCore db = new EntitiesDeviceDomainCore();
            var DbResult = from d in db.CypherKey where d.RemainingFolios.HasValue
                           select new
                           {
                               d.SerialNumber,
                               d.RemainingFolios
                           };

            return Json(DbResult, JsonRequestBehavior.AllowGet);
        }
    }
}