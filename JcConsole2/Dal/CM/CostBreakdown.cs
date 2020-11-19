namespace Dal.CM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CostBreakdown")]
    public partial class CostBreakdown
    {
        public int id { get; set; }

        public DateTime? thedate { get; set; }

        public long? shopId { get; set; }

        public long? Itemid { get; set; }

        public decimal? DirectTrain { get; set; }

        public decimal? PerFriend { get; set; }

        public decimal? DrillShow { get; set; }

        public decimal? Taoke { get; set; }

        public decimal? RewardService { get; set; }

        public decimal? Cashback { get; set; }

        public decimal? OtherExpenses { get; set; }

        public decimal? PriceSpread { get; set; }

        public int? OrderNumber { get; set; }

        public decimal? amount { get; set; }

        public decimal? brokerage { get; set; }

        public decimal? LqCost { get; set; }

        public decimal? RefundAmount { get; set; }

        [StringLength(800)]
        public string FinanceRemark { get; set; }

        [StringLength(800)]
        public string CostRemark { get; set; }
    }
}
