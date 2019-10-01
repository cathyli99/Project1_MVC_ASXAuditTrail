using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MvcLab01.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MvcLab01.Controllers
{
    [Route("api/[controller]")]
    public class MarketDataController : Controller
    {
        private readonly ASXAuditTrailContext db;
        public MarketDataController(ASXAuditTrailContext sc)
        {
            db = sc;
        }

        // GET api/<controller>/5
        [HttpGet("{code}/{offset}/{rows}")]
        public List<MarketChartPrice> Get(string code, int offset, int rows)
        {
            return db.GetMarketChartPricesAsync(code, offset, rows);
        }

    }
}
