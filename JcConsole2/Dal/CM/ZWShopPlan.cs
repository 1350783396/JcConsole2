namespace Dal.CM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ZWShopPlan")]
    public partial class ZWShopPlan
    {
        public long id { get; set; }

        public int ShopID { get; set; }

        public int Day { get; set; }

        public int SalesVolume { get; set; }

        public decimal UnitPrice { get; set; }

        public decimal payPercent { get; set; }

        public decimal GrossProfitPercent { get; set; }

        public decimal RepairOrderCost { get; set; }

        public decimal RepairOrderPercent { get; set; }

        public int ThroughTrainPercent { get; set; }

        public int DiamondBoothPercent { get; set; }

        public int HandSearchPercent { get; set; }

        public int TaoBaoIndexPercent { get; set; }

        public int OtherWayPercent { get; set; }

        public decimal ThroughTrainRate { get; set; }

        public decimal DiamondBoothRate { get; set; }

        public decimal HandSearchRate { get; set; }

        public decimal TaoBaoIndexRate { get; set; }

        public decimal OtherWayRate { get; set; }

        public decimal ThroughTrainSingleVolume { get; set; }

        public decimal DiamondBoothSingleVolume { get; set; }

        public long? itemID { get; set; }

        public virtual TB_TaobaoShop TB_TaobaoShop { get; set; }
    }
}
