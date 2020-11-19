namespace Dal.CM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TacticsWeekConfig")]
    public partial class TacticsWeekConfig
    {
        public int id { get; set; }

        public long item { get; set; }

        public long ShopID { get; set; }

        public DateTime CreateDate { get; set; }

        public int week { get; set; }

        public decimal? incrementRatio { get; set; }

        public decimal? articlePrice { get; set; }

        public decimal? conversionRate { get; set; }

        public decimal? uvCost { get; set; }

        public decimal? payFluxRatio { get; set; }
    }
}
