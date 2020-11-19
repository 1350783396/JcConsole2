namespace Dal.CM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CostData")]
    public partial class CostData
    {
        public int id { get; set; }

        public DateTime thedate { get; set; }

        public long shopId { get; set; }

        public long jzitemId { get; set; }

        public decimal? transactionPrice { get; set; }

        public decimal? costPrice { get; set; }

        public decimal? platformCommission { get; set; }

        public decimal? freightCost { get; set; }

        public decimal? elseCost { get; set; }

        public decimal? expSumPrice { get; set; }

        public decimal? expGrossProfitRate { get; set; }

        public decimal? ztcClickPrice { get; set; }

        public decimal? cjtjClickPrice { get; set; }

        public decimal? tbkCommissionExtract { get; set; }

        public DateTime? updateDate { get; set; }
    }
}
