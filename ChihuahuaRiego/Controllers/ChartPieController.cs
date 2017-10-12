using ChihuahuaRiego.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services;

namespace ChihuahuaRiego.Controllers
{
    public class ChartPieController : Controller
    {
        // GET: ChartPie
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public List<Riego> getRiego()
        {
            List<Riego> p = new List<Riego>();

            var items = new List<Riego>();
            items.Add(new Riego { Fecha = "20/04/2017", RiegoTipo = 5 });
            items.Add(new Riego { Fecha = "01/05/2017", RiegoTipo = 10 });
            items.Add(new Riego { Fecha = "07/06/2017", RiegoTipo = 20 });
            items.Add(new Riego { Fecha = "01/07/2017", RiegoTipo = 5 });
            items.Add(new Riego { Fecha = "20/07/2017", RiegoTipo = 20 });
            items.Add(new Riego { Fecha = "01/08/2017", RiegoTipo = 10 });


            var dataForChart = items.Select(x => new { names = x.Fecha, y = x.RiegoTipo });

            //return Json(dataForChart, JsonRequestBehavior.AllowGet);
            return items;
        }
    }
}