using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using MvcLab01.Models;

namespace MvcLab01.ViewModels
{
    public class Home
    {
        public string SecCode { get; set; }
        public int OffsetCount { get; set; }
        public int RowCount { get; set; }
        public List<MarketChartPrice> MarketChartPrice { get; set; }
    }
}
