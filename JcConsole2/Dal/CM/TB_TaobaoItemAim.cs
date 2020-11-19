namespace Dal.CM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_TaobaoItemAim
    {
        public int id { get; set; }

        public long ItemId { get; set; }

        public int year { get; set; }

        public int month { get; set; }

        public decimal Money { get; set; }

        public decimal Price { get; set; }

        public int MonthCount { get; set; }

        public int DayCount { get; set; }

        public DateTime? UpdateDate { get; set; }

        public int ShopID { get; set; }

        public decimal? budget { get; set; }

        public virtual TB_TaobaoShop TB_TaobaoShop { get; set; }
    }
}
