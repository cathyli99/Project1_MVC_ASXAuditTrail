using System;
using System.Collections.Generic;

namespace MvcLab01.Models
{
    public partial class Calendar
    {
        public int? Id { get; set; }
        public DateTime EventDate { get; set; }
        public int? IsTradingDate { get; set; }
        public int? IsSettlementDate { get; set; }
        public string Remark { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateBy { get; set; }
    }
}
