namespace Dal.CM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_TaobaoItemWeekPlan
    {
        public int id { get; set; }

        public long ItemId { get; set; }

        public int ItemAimId { get; set; }

        public int WeekId { get; set; }

        public int Year { get; set; }

        public int Month { get; set; }

        public DateTime StartDate { get; set; }

        public int Days { get; set; }

        [StringLength(255)]
        public string WeekDesc { get; set; }

        public int OrderCount { get; set; }

        public DateTime CreateDate { get; set; }

        public int ShopID { get; set; }

        public virtual TB_TaobaoShop TB_TaobaoShop { get; set; }
    }
}
