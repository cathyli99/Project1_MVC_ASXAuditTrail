using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MvcLab01.Models;
using MvcLab01.ViewModels;

namespace MvcLab01.Controllers
{
    public class HomeController : Controller
    {
        private readonly ASXAuditTrailContext db;
        public HomeController(ASXAuditTrailContext sc)
        {
            db = sc;
        }
        public IActionResult Index()
        {
            Home home = new Home()
            {
                SecCode = "SAM",
                OffsetCount = 0,
                RowCount = 300,
            };
            home.MarketChartPrice = db.GetMarketChartPricesAsync(home.SecCode, home.OffsetCount, home.RowCount);
            return View(home);
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
