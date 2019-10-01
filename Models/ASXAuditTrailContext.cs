using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MvcLab01.Models
{
    public partial class ASXAuditTrailContext : DbContext
    {
        public ASXAuditTrailContext()
        {
        }

        public ASXAuditTrailContext(DbContextOptions<ASXAuditTrailContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Calendar> Calendar { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<SecBoard> SecBoard { get; set; }
        public virtual DbSet<Trade> Trade { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                //optionsBuilder.UseSqlServer("Data Source=45.63.29.195,56668; Initial Catalog=ASXAuditTrail; User Id=asxauditrail; Password=Go!Iters2198x; Persist Security Info=False; MultipleActiveResultSets=True; Connect Timeout=120;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            // Register store procedure custom object
            modelBuilder.Query<MarketChartPrice>();
          

            modelBuilder.Entity<Calendar>(entity =>
            {
                entity.HasKey(e => e.EventDate);

                entity.Property(e => e.EventDate).HasColumnType("datetime");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Remark).HasMaxLength(50);

                entity.Property(e => e.UpdateBy).HasMaxLength(50);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Orders>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountChoice).HasMaxLength(20);

                entity.Property(e => e.ActionOnLogoff).HasMaxLength(20);

                entity.Property(e => e.AutoOrManual).HasMaxLength(20);

                entity.Property(e => e.Balance).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.BaseCurrValue).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.BoardId).HasMaxLength(20);

                entity.Property(e => e.BrokerRef).HasMaxLength(255);

                entity.Property(e => e.BuySell).HasMaxLength(20);

                entity.Property(e => e.Comment).HasMaxLength(255);

                entity.Property(e => e.Duration).HasMaxLength(50);

                entity.Property(e => e.ExternalOrderId).HasMaxLength(20);

                entity.Property(e => e.FirmId).HasMaxLength(30);

                entity.Property(e => e.GiveUpFirmId).HasMaxLength(10);

                entity.Property(e => e.GiveUpRef).HasMaxLength(255);

                entity.Property(e => e.InstrId).HasMaxLength(12);

                entity.Property(e => e.IsPublic).HasMaxLength(1);

                entity.Property(e => e.IsShort).HasMaxLength(1);

                entity.Property(e => e.MatchQty).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Mir).HasMaxLength(1);

                entity.Property(e => e.MktPriceData).HasMaxLength(255);

                entity.Property(e => e.OperatorId).HasMaxLength(30);

                entity.Property(e => e.OrderDate).HasColumnType("date");

                entity.Property(e => e.OrderStatus).HasMaxLength(20);

                entity.Property(e => e.OrderType).HasMaxLength(50);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Quantity).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.SecCode).HasMaxLength(100);

                entity.Property(e => e.SessDurationId).HasMaxLength(12);

                entity.Property(e => e.SettleDate).HasColumnType("date");

                entity.Property(e => e.Shared).HasMaxLength(1);

                entity.Property(e => e.ShortBrokerRef).HasMaxLength(32);

                entity.Property(e => e.SiteSpecificBlobData).HasMaxLength(255);

                entity.Property(e => e.TrackingType).HasMaxLength(50);

                entity.Property(e => e.TradeReference).HasMaxLength(255);

                entity.Property(e => e.TradingQty).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.UpdateOperatorId).HasMaxLength(50);

                entity.Property(e => e.UserId).HasMaxLength(30);

                entity.Property(e => e.Value).HasColumnType("decimal(38, 4)");
            });

            modelBuilder.Entity<SecBoard>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountChoiceType).HasMaxLength(50);

                entity.Property(e => e.AccruedInterest).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.AccruedInterestVal).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.BidDepth).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.BidPrice).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.BoardGroupId).HasMaxLength(20);

                entity.Property(e => e.BoardId)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.CbRefPrice).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.ChangePercent).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ChangePrice).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.CurrencyId).HasMaxLength(3);

                entity.Property(e => e.CurrencyIdLang2).HasMaxLength(3);

                entity.Property(e => e.DefaultScalingFactor).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.High52WeekDate).HasColumnType("date");

                entity.Property(e => e.High52WeekPrice).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.HighPrice).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.InheritedState).HasMaxLength(50);

                entity.Property(e => e.InstrId).HasMaxLength(12);

                entity.Property(e => e.IsNegativePriceAllowed).HasMaxLength(1);

                entity.Property(e => e.IsTradeable)
                    .HasColumnName("isTradeable")
                    .HasMaxLength(1);

                entity.Property(e => e.IsUnderlyingToOption).HasMaxLength(1);

                entity.Property(e => e.Isin).HasMaxLength(12);

                entity.Property(e => e.IssueDate).HasColumnType("date");

                entity.Property(e => e.IssuerId).HasMaxLength(20);

                entity.Property(e => e.LastPrice).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.LastQuantity).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Low52WeekDate).HasColumnType("date");

                entity.Property(e => e.Low52WeekPrice).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.LowPrice).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.MarketCap).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.MidPriceHigh).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.MidPriceLow).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.MktPrice).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.MmquotationStatus)
                    .HasColumnName("MMQuotationStatus")
                    .HasMaxLength(50);

                entity.Property(e => e.NbboBidMkt).HasMaxLength(50);

                entity.Property(e => e.NbboOfferMkt).HasMaxLength(50);

                entity.Property(e => e.NlevelImpBidChainLength).HasColumnName("NLevelImpBidChainLength");

                entity.Property(e => e.NlevelImpBidTrdAccId)
                    .HasColumnName("NLevelImpBidTrdAccId")
                    .HasMaxLength(50);

                entity.Property(e => e.NlevelImpOfferChainLength).HasColumnName("NLevelImpOfferChainLength");

                entity.Property(e => e.NlevelImpOfferTrdAccId)
                    .HasColumnName("NLevelImpOfferTrdAccId")
                    .HasMaxLength(50);

                entity.Property(e => e.OffMktLastPrice).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.OffMktValueToday).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.OffMktVolumeToday).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.OfferDepth).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.OfferPrice).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.OpenPrice).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.OpenQuantity).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Paylequivcollat).HasColumnType("decimal(38, 9)");

                entity.Property(e => e.Paylequivnoncollat).HasColumnType("decimal(38, 9)");

                entity.Property(e => e.PrevDate).HasColumnType("date");

                entity.Property(e => e.PrevPrice).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.QtyMultiplier).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.QuoteBases).HasMaxLength(50);

                entity.Property(e => e.Reclequivcollat).HasColumnType("decimal(38, 9)");

                entity.Property(e => e.Reclequivnoncollat).HasColumnType("decimal(38, 9)");

                entity.Property(e => e.RefPrice).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.SecBoardChangedFields).HasMaxLength(255);

                entity.Property(e => e.SecBoardState).HasMaxLength(20);

                entity.Property(e => e.SecClassId).HasMaxLength(20);

                entity.Property(e => e.SecCode)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.SecName).HasMaxLength(255);

                entity.Property(e => e.SecNameLang2).HasMaxLength(255);

                entity.Property(e => e.SecShortName).HasMaxLength(100);

                entity.Property(e => e.SessionName).HasMaxLength(30);

                entity.Property(e => e.SettleDate).HasColumnType("date");

                entity.Property(e => e.ShortSellStatus).HasMaxLength(50);

                entity.Property(e => e.TradeDate).HasColumnType("date");

                entity.Property(e => e.TrmaxQty)
                    .HasColumnName("TRMaxQty")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.TrminQty)
                    .HasColumnName("TRMinQty")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.TrorderMethods)
                    .HasColumnName("TROrderMethods")
                    .HasMaxLength(255);

                entity.Property(e => e.TrrefMoveDownStepArrayId).HasColumnName("TRRefMoveDownStepArrayId");

                entity.Property(e => e.TrrefmoveUpStepArrayId).HasColumnName("TRRefmoveUpStepArrayId");

                entity.Property(e => e.UnadjPrevPrice).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.ValueToday).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.VolumeToday).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.WaPrice).HasColumnType("decimal(18, 3)");
            });

            modelBuilder.Entity<Trade>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .ForSqlServerIsClustered(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AggressorOrderVerb).HasMaxLength(10);

                entity.Property(e => e.AlertStatus).HasMaxLength(10);

                entity.Property(e => e.BaseCurrValue).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.BoardId).HasMaxLength(20);

                entity.Property(e => e.BuyAccountChoice).HasMaxLength(10);

                entity.Property(e => e.BuyBrokerRef).HasMaxLength(255);

                entity.Property(e => e.BuyFirmId).HasMaxLength(30);

                entity.Property(e => e.BuyGiveUpRef).HasMaxLength(255);

                entity.Property(e => e.BuyMir).HasMaxLength(1);

                entity.Property(e => e.BuyOperatorId).HasMaxLength(30);

                entity.Property(e => e.BuyOrderDate).HasColumnType("date");

                entity.Property(e => e.BuyShortBrokerRef).HasMaxLength(255);

                entity.Property(e => e.BuyTradeRef).HasMaxLength(255);

                entity.Property(e => e.BuyTraderId).HasMaxLength(30);

                entity.Property(e => e.InstrId).HasMaxLength(12);

                entity.Property(e => e.IsAutoTrade).HasMaxLength(1);

                entity.Property(e => e.IsBuyOrderPublic).HasMaxLength(1);

                entity.Property(e => e.IsLastPriceUpdated).HasMaxLength(1);

                entity.Property(e => e.IsSellOrderPublic).HasMaxLength(1);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Quantity).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.SecCode).HasMaxLength(100);

                entity.Property(e => e.SellAccountChoice).HasMaxLength(10);

                entity.Property(e => e.SellBrokerRef).HasMaxLength(255);

                entity.Property(e => e.SellFirmId).HasMaxLength(30);

                entity.Property(e => e.SellGiveUpRef).HasMaxLength(255);

                entity.Property(e => e.SellMir).HasMaxLength(1);

                entity.Property(e => e.SellOperatorId).HasMaxLength(30);

                entity.Property(e => e.SellOrderDate).HasColumnType("date");

                entity.Property(e => e.SellShortBrokerRef).HasMaxLength(255);

                entity.Property(e => e.SellTradeRef).HasMaxLength(255);

                entity.Property(e => e.SellTraderId).HasMaxLength(30);

                entity.Property(e => e.SettleDate).HasColumnType("date");

                entity.Property(e => e.SettlementValue).HasColumnType("decimal(38, 4)");

                entity.Property(e => e.Status).HasMaxLength(20);

                entity.Property(e => e.TradeNo).HasMaxLength(50);

                entity.Property(e => e.TradeSourceId).HasMaxLength(4);

                entity.Property(e => e.TradeSourceName).HasMaxLength(50);

                entity.Property(e => e.Value).HasColumnType("decimal(38, 4)");
            });

            // Register store procedure custom object.
            modelBuilder.Query<MarketChartPrice>();

        }
       public List<MarketChartPrice> GetMarketChartPricesAsync(string secCode,int rowOffset,int rowCount)
        {
            // Initialization.  
            List<MarketChartPrice> lst;

            try
            {
                // Processing.  
                lst = Query<MarketChartPrice>().FromSql("GetMarketPricesBySecurityCode @p0, @p1, @p2", secCode, rowOffset, rowCount).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            // Info.  
            return lst;
        }
   
    }
}
