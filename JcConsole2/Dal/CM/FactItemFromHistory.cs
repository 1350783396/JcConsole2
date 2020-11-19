namespace Dal.CM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FactItemFromHistory")]
    public partial class FactItemFromHistory
    {
        public int id { get; set; }

        public long item { get; set; }

        [Required]
        [StringLength(64)]
        public string qudao { get; set; }

        public int uv { get; set; }

        public decimal uvPercent { get; set; }

        public DateTime CreateDate { get; set; }

        public int ShopID { get; set; }

        public virtual TB_TaobaoShop TB_TaobaoShop { get; set; }
    }
}
