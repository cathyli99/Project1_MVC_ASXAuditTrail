using System;
using System.Collections.Generic;

namespace MvcLab01.Models
{
    public partial class Trade
    {
        public long Id { get; set; }
        public DateTime TimeStamp { get; set; }
        public string TradeNo { get; set; }
        public DateTime? BuyOrderDate { get; set; }
        public int? BuyOrderNo { get; set; }
        public int? BuyOrderSuffix { get; set; }
        public DateTime? SellOrderDate { get; set; }
        public int? SellOrderNo { get; set; }
        public int? SellOrderSuffix { get; set; }
        public DateTime? Time { get; set; }
        public string BuyBrokerRef { get; set; }
        public string SellBrokerRef { get; set; }
        public string BuyTraderId { get; set; }
        public string SellTraderId { get; set; }
        public string BuyOperatorId { get; set; }
        public string SellOperatorId { get; set; }
        public string BuyFirmId { get; set; }
        public string SellFirmId { get; set; }
        public string SecCode { get; set; }
        public string BoardId { get; set; }
        public string InstrId { get; set; }
        public decimal? Price { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? Value { get; set; }
        public decimal? SettlementValue { get; set; }
        public string TradeSourceId { get; set; }
        public string TradeSourceName { get; set; }
        public DateTime? SettleDate { get; set; }
        public string IsAutoTrade { get; set; }
        public string IsBuyOrderPublic { get; set; }
        public string IsSellOrderPublic { get; set; }
        public string BuyShortBrokerRef { get; set; }
        public string SellShortBrokerRef { get; set; }
        public string AggressorOrderVerb { get; set; }
        public decimal? BaseCurrValue { get; set; }
        public string BuyGiveUpRef { get; set; }
        public string SellGiveUpRef { get; set; }
        public string IsLastPriceUpdated { get; set; }
        public string Status { get; set; }
        public string BuyAccountChoice { get; set; }
        public string SellAccountChoice { get; set; }
        public DateTime? AmendTime { get; set; }
        public string AlertStatus { get; set; }
        public string BuyTradeRef { get; set; }
        public string SellTradeRef { get; set; }
        public string BuyMir { get; set; }
        public string SellMir { get; set; }
    }
}
