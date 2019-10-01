using System;
using System.Collections.Generic;

namespace MvcLab01.Models
{
    public partial class Orders
    {
        public long Id { get; set; }
        public DateTime TimeStamp { get; set; }
        public DateTime? OrderDate { get; set; }
        public int? OrderNo { get; set; }
        public int? OrderNoSuffix { get; set; }
        public string SecCode { get; set; }
        public string BoardId { get; set; }
        public string InstrId { get; set; }
        public string BuySell { get; set; }
        public string FirmId { get; set; }
        public DateTime? EntryTime { get; set; }
        public string AutoOrManual { get; set; }
        public DateTime? SettleDate { get; set; }
        public string UserId { get; set; }
        public string OperatorId { get; set; }
        public string OrderStatus { get; set; }
        public decimal? Price { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? Balance { get; set; }
        public decimal? Value { get; set; }
        public string AccountChoice { get; set; }
        public string TradeReference { get; set; }
        public string BrokerRef { get; set; }
        public string SessDurationId { get; set; }
        public string Duration { get; set; }
        public DateTime? AmendTime { get; set; }
        public decimal? TradingQty { get; set; }
        public decimal? MatchQty { get; set; }
        public string SiteSpecificBlobData { get; set; }
        public string MktPriceData { get; set; }
        public string ExternalOrderId { get; set; }
        public string ActionOnLogoff { get; set; }
        public string IsPublic { get; set; }
        public string TrackingType { get; set; }
        public string OrderType { get; set; }
        public string Shared { get; set; }
        public string UpdateOperatorId { get; set; }
        public string Comment { get; set; }
        public string ShortBrokerRef { get; set; }
        public string IsShort { get; set; }
        public string GiveUpFirmId { get; set; }
        public string GiveUpRef { get; set; }
        public decimal? BaseCurrValue { get; set; }
        public string Mir { get; set; }
    }
}
