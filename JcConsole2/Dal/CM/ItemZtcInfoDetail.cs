namespace Dal.CM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ItemZtcInfoDetail")]
    public partial class ItemZtcInfoDetail
    {
        public int id { get; set; }

        public DateTime thedate { get; set; }

        [StringLength(64)]
        public string keyword { get; set; }

        public int uv { get; set; }

        public int pv { get; set; }

        public decimal pv_percent { get; set; }

        public int shopIdCount { get; set; }

        public int outCount { get; set; }

        public int collect { get; set; }

        public int shopCat { get; set; }

        public int byCount { get; set; }

        public decimal order_percent { get; set; }

        public int pay { get; set; }

        public int payBuyer { get; set; }

        public decimal pay_percent { get; set; }

        public long itemId { get; set; }

        public int ShopID { get; set; }

        public virtual TB_TaobaoShop TB_TaobaoShop { get; set; }
    }
}
