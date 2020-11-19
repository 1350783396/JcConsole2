namespace Dal.CM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ItemZtcDateInfo")]
    public partial class ItemZtcDateInfo
    {
        public int id { get; set; }

        public DateTime thedate { get; set; }

        public DateTime updateDate { get; set; }

        public long itemId { get; set; }

        public int ShopID { get; set; }

        public virtual TB_TaobaoShop TB_TaobaoShop { get; set; }
    }
}
