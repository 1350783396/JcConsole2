namespace Dal.CM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_TaobaoItemStrategy
    {
        public int id { get; set; }

        public int ItemWeekPlanID { get; set; }

        public int Year { get; set; }

        public int Month { get; set; }

        public long ItemId { get; set; }

        [StringLength(800)]
        public string Stratety { get; set; }

        public DateTime CreateDate { get; set; }

        [StringLength(800)]
        public string Summery { get; set; }

        public DateTime? FinishDate { get; set; }

        public int ShopID { get; set; }

        public virtual TB_TaobaoShop TB_TaobaoShop { get; set; }
    }
}
