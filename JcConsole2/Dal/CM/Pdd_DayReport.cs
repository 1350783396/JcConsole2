namespace Dal.CM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Pdd_DayReport
    {
        public int id { get; set; }

        public DateTime thedate { get; set; }

        public int? BlueflagOrder { get; set; }

        public decimal? BlueflagMoney { get; set; }

        public decimal? payMoney { get; set; }

        public int? PayBuyer { get; set; }

        public int? PayOrder { get; set; }

        public string Conversion { get; set; }

        public decimal? PayPrice { get; set; }

        public int? CommodityVisit { get; set; }

        public int? CommoditViews { get; set; }

        public int? CommoditTurnover { get; set; }

        public int? VisitCommodity { get; set; }

        public int? CommodityCollect { get; set; }

        public decimal? RefundMoney { get; set; }

        public int? RefundOrder { get; set; }

        public string PlatformInsertRate { get; set; }

        public string PlatformRefundRate { get; set; }

        public int? PlatformRefundAvg { get; set; }

        public string ThreeReplyRate { get; set; }

        public decimal? AvgPopleReply { get; set; }

        public string InquiryChangeRate { get; set; }

        public decimal? SaleMoney { get; set; }

        public int? shopId { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? otherMoney { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? activityMoney { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? spreadMoney { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? blueflagCommission { get; set; }
    }
}
