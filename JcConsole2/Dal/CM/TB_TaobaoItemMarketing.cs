namespace Dal.CM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_TaobaoItemMarketing
    {
        public int id { get; set; }

        public DateTime StartDate { get; set; }

        public int Days { get; set; }

        public DateTime EndDate { get; set; }

        [Required]
        [StringLength(255)]
        public string MarketingTitle { get; set; }

        [Required]
        public string Content { get; set; }

        [StringLength(32)]
        public string Author { get; set; }

        public decimal? Fee { get; set; }

        public long ItemId { get; set; }

        public DateTime CreateDate { get; set; }

        public int ShopID { get; set; }

        public int? TypeID { get; set; }

        public int? TaskID { get; set; }

        public virtual TB_TaobaoShop TB_TaobaoShop { get; set; }
    }
}
