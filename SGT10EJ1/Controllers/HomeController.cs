using Microsoft.AspNetCore.Mvc;
using SGT10EJ1.Models;
using Microsoft.Data.SqlClient;
using System.Diagnostics;

namespace SGT10EJ1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(String potato) {
            SqlConnection conn = new SqlConnection();
            System.Data.ConnectionState connState = System.Data.ConnectionState.Closed;
            try
            {
                conn.ConnectionString = "server=alonso.database.windows.net;database=alonso-db;uid=usuario;pwd=LaCampana123;trustServerCertificate=true;";
                conn.Open();
                connState = conn.State;
            }
            catch (Exception)
            {
                connState = System.Data.ConnectionState.Closed;
            }
            finally {
                conn.Close();
            }
            return View("Index", connState.ToString());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
