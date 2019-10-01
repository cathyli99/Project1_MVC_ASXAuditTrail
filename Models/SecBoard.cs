using System;
using System.Collections.Generic;

namespace MvcLab01.Models
{
    public partial class SecBoard
    {
        public long Id { get; set; }
        public DateTime TimeStamp { get; set; }
        public string SecCode { get; set; }
        public string BoardId { get; set; }
        public string SecName { get; set; }
        public string SecNameLang2 { get; set; }
        public string SecShortName { get; set; }
        public string IssuerId { get; set; }
        public string BoardGroupId { get; set; }
        public string SecClassId { get; set; }
        public string InstrId { get; set; }
        public string CurrencyId { get; set; }
        public string CurrencyIdLang2 { get; set; }
        public string Isin { get; set; }
        public string IsTradeable { get; set; }
        public int? PriceDecimals { get; set; }
        public int? QuantityDecimals { get; set; }
        public int? YieldDecimals { get; set; }
        public string IsUnderlyingToOption { get; set; }
        public int? MinPriceStepArrayId { get; set; }
        public int? MinQtyStepArrayId { get; set; }
        public DateTime? IssueDate { get; set; }
        public DateTime? SettleDate { get; set; }
        public decimal? AccruedInterest { get; set; }
        public string IsNegativePriceAllowed { get; set; }
        public string SecBoardState { get; set; }
        public string TrorderMethods { get; set; }
        public decimal? TrminQty { get; set; }
        public decimal? TrmaxQty { get; set; }
        public int? TrrefmoveUpStepArrayId { get; set; }
        public int? TrrefMoveDownStepArrayId { get; set; }
        public string SessionName { get; set; }
        public string InheritedState { get; set; }
        public string MmquotationStatus { get; set; }
        public decimal? BidPrice { get; set; }
        public decimal? BidDepth { get; set; }
        public int? NumBids { get; set; }
        public string NbboBidMkt { get; set; }
        public string NbboOfferMkt { get; set; }
        public decimal? CbRefPrice { get; set; }
        public decimal? RefPrice { get; set; }
        public decimal? OpenPrice { get; set; }
        public decimal? OpenQuantity { get; set; }
        public decimal? HighPrice { get; set; }
        public decimal? LowPrice { get; set; }
        public decimal? WaPrice { get; set; }
        public decimal? LastPrice { get; set; }
        public DateTime? LastTime { get; set; }
        public decimal? LastQuantity { get; set; }
        public decimal? ChangePrice { get; set; }
        public int? NumTrades { get; set; }
        public decimal? VolumeToday { get; set; }
        public decimal? ValueToday { get; set; }
        public decimal? OffMktLastPrice { get; set; }
        public DateTime? PrevDate { get; set; }
        public decimal? PrevPrice { get; set; }
        public decimal? UnadjPrevPrice { get; set; }
        public DateTime? TradeDate { get; set; }
        public string SecBoardChangedFields { get; set; }
        public decimal? Paylequivcollat { get; set; }
        public decimal? Reclequivcollat { get; set; }
        public decimal? Paylequivnoncollat { get; set; }
        public decimal? Reclequivnoncollat { get; set; }
        public decimal? MktPrice { get; set; }
        public decimal? DefaultScalingFactor { get; set; }
        public int? NlevelImpBidChainLength { get; set; }
        public string NlevelImpBidTrdAccId { get; set; }
        public int? NlevelImpOfferChainLength { get; set; }
        public string NlevelImpOfferTrdAccId { get; set; }
        public decimal? High52WeekPrice { get; set; }
        public DateTime? High52WeekDate { get; set; }
        public decimal? Low52WeekPrice { get; set; }
        public DateTime? Low52WeekDate { get; set; }
        public decimal? MidPriceLow { get; set; }
        public decimal? MidPriceHigh { get; set; }
        public decimal? QtyMultiplier { get; set; }
        public decimal? ChangePercent { get; set; }
        public int? NumOrders { get; set; }
        public int? NumOpenOrders { get; set; }
        public string ShortSellStatus { get; set; }
        public decimal? MarketCap { get; set; }
        public string AccountChoiceType { get; set; }
        public decimal? AccruedInterestVal { get; set; }
        public decimal? OfferPrice { get; set; }
        public decimal? OfferDepth { get; set; }
        public int? NumOffers { get; set; }
        public decimal? OffMktValueToday { get; set; }
        public decimal? OffMktVolumeToday { get; set; }
        public string QuoteBases { get; set; }
    }
}
