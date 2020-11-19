namespace Dal.CM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_TaobaoItemSeo
    {
        public int id { get; set; }

        public DateTime day { get; set; }

        [Required]
        [StringLength(255)]
        public string TitleDo { get; set; }

        [Required]
        [StringLength(64)]
        public string MainKeyword { get; set; }

        [Required]
        [StringLength(64)]
        public string DownDate { get; set; }

        [StringLength(800)]
        public string Remark { get; set; }

        public long ItemId { get; set; }

        public DateTime CreateDate { get; set; }

        public int ShopID { get; set; }

        public bool IsMobile { get; set; }

        public virtual TB_TaobaoShop TB_TaobaoShop { get; set; }
    }
}
