using System.Web.Mvc;
using Newtonsoft.Json;
using System.Data;

namespace ChihuahuaRiego.Controllers
{
    public class ChartController : Controller
    {
        // GET: Chart
        public ActionResult Index()
        {
            DataTable table = DerializeDataTable();

            return View(table);
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