namespace Dal.CM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ItemIndustryWordsHistory")]
    public partial class ItemIndustryWordsHistory
    {
        public int id { get; set; }

        [StringLength(64)]
        public string keyword { get; set; }

        public DateTime updateDate { get; set; }

        public long itemId { get; set; }

        public int ShopID { get; set; }

        public virtual TB_TaobaoShop TB_TaobaoShop { get; set; }
    }
}
