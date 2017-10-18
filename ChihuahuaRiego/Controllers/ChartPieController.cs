using ChihuahuaRiego.Models;
using RiegoChihuahua.Modelo;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using RiegoChihuahua.Calculo;
using System.Data;

namespace ChihuahuaRiego.Controllers
{
    public class ChartPieController : Controller
    {
        // GET: ChartPie
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetChart()
        {
            Riego obj = new Riego();
            DataTable dt = new DataTable();

            dt = obj.CalculoRequerimientoHidrico(19, "20/04/2017", "20/09/2017");

            //List<MResumenRiego> listRiego = obj.GetResumenRiego(dt);

            var data = obj.GetGraficaRiego();

//            < Balance > 10.72952 </ Balance >
//< Dds > 1 </ Dds >
            //var data = new List<Riego>(){
            //    new Riego() { Fecha = "20/04/2017", RiegoTipo = 5 },
            //    new Riego() { Fecha = "01/05/2017", RiegoTipo = 10 },
            //    new Riego() { Fecha = "07/06/2017", RiegoTipo = 20 },
            //    new Riego() { Fecha = "01/07/2017", RiegoTipo = 5 },
            //    new Riego() { Fecha = "20/07/2017", RiegoTipo = 20 },
            //    new Riego() { Fecha = "01/08/2017", RiegoTipo = 10 }
            //};



             var dataforchart = data.Select(x => new { name = x.Balance, y = x.Dds });

            return Json(dataforchart, JsonRequestBehavior.AllowGet);
        }



        //[HttpGet]
        //public List<Riego> getRiego()
        //{
        //    List<Riego> p = new List<Riego>();

        //    var items = new List<Riego>();
        //    items.Add(new Riego { Fecha = "20/04/2017", RiegoTipo = 5 });
        //    items.Add(new Riego { Fecha = "01/05/2017", RiegoTipo = 10 });
        //    items.Add(new Riego { Fecha = "07/06/2017", RiegoTipo = 20 });
        //    items.Add(new Riego { Fecha = "01/07/2017", RiegoTipo = 5 });
        //    items.Add(new Riego { Fecha = "20/07/2017", RiegoTipo = 20 });
        //    items.Add(new Riego { Fecha = "01/08/2017", RiegoTipo = 10 });


        //    var dataForChart = items.Select(x => new { names = x.Fecha, y = x.RiegoTipo });

        //    //return Json(dataForChart, JsonRequestBehavior.AllowGet);
        //    return items;
        //}
    }
}