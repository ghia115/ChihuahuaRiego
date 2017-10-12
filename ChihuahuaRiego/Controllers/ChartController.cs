﻿using System.Web.Mvc;
using Newtonsoft.Json;
using System.Data;
using ChihuahuaRiego.Models;
using System.Collections.Generic;
using System.Linq;

namespace ChihuahuaRiego.Controllers
{
    public class ChartController : Controller
    {
        // GET: Chart
        public ActionResult Index()
        {
            //DataTable table = DerializeDataTable();

            var items = new List<Riego>();
            items.Add(new Riego { Fecha = "20/04/2017", RiegoTipo = 5 });
            items.Add(new Riego { Fecha = "01/05/2017", RiegoTipo = 10 });
            items.Add(new Riego { Fecha = "07/06/2017", RiegoTipo = 20 });
            items.Add(new Riego { Fecha = "01/07/2017", RiegoTipo = 5 });
            items.Add(new Riego { Fecha = "20/07/2017", RiegoTipo = 20 });
            items.Add(new Riego { Fecha = "01/08/2017", RiegoTipo = 10 });

            
            var dataForChart = items.Select(x => new {names = x.Fecha, y = x.RiegoTipo});

            //return Json(dataForChart, JsonRequestBehavior.AllowGet);
            return View();
        }

        public DataTable DerializeDataTable()
        {
            const string json = @"[{""fecha"": ""20/04/2017"", ""riego"": 5},"
                               + @"{""fecha"": ""01/05/2017"", ""riego"": 10},"
                               + @"{""fecha"": ""07/06/2017"", ""riego"": 20},"
                               + @"{""fecha"": ""01/07/2017"", ""riego"": 5},"
                               + @"{""fecha"": ""20/07/2017"", ""riego"": 20},"
                               + @"{""fecha"": ""01/08/2017"", ""riego"": 10}]";

            var table = JsonConvert.DeserializeObject<DataTable>(json);
            return table;
        }
    }
}