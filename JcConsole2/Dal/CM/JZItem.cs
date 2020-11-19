namespace Dal.CM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("JZItem")]
    public partial class JZItem
    {
        public int id { get; set; }

        public long item { get; set; }

        [Column("jzItem")]
        public long jzItem1 { get; set; }

        [Required]
        [StringLength(255)]
        public string title { get; set; }

        [Required]
        [StringLength(255)]
        public string pic { get; set; }

        [StringLength(64)]
        public string price { get; set; }

        [Required]
        [StringLength(255)]
        public string shopName { get; set; }

        public DateTime? CreateDate { get; set; }

        public int ShopID { get; set; }

        [StringLength(255)]
        public string catId { get; set; }

        [StringLength(800)]
        public string url { get; set; }

        public int? isMonitoring { get; set; }

        public int? sort { get; set; }

        public int? isOpen { get; set; }

        [StringLength(800)]
        public string remark { get; set; }

        [StringLength(50)]
        public string province { get; set; }

        [StringLength(50)]
        public string city { get; set; }

        public int? b2CShop { get; set; }

        [StringLength(255)]
        public string pictureUrl { get; set; }

        [StringLength(255)]
        public string shopUrl { get; set; }

        public virtual TB_TaobaoShop TB_TaobaoShop { get; set; }
    }
}
