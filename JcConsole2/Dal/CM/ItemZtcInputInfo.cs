namespace Dal.CM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ItemZtcInputInfo")]
    public partial class ItemZtcInputInfo
    {
        public int id { get; set; }

        public DateTime thedate { get; set; }

        public long itemId { get; set; }

        public decimal ztcMoney { get; set; }

        public int ztcShow { get; set; }

        public int ShopID { get; set; }

        public virtual TB_TaobaoShop TB_TaobaoShop { get; set; }
    }
}
