namespace Dal.CM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SubWayClick")]
    public partial class SubWayClick
    {
        public int id { get; set; }

        public DateTime thedate { get; set; }

        public long custid { get; set; }

        public long campaignid { get; set; }

        public long adgroupid { get; set; }

        [Required]
        [StringLength(200)]
        public string clickid { get; set; }

        public DateTime clicktime { get; set; }

        public decimal cost { get; set; }

        [Required]
        [StringLength(50)]
        public string clickTimeStr { get; set; }

        [Required]
        [StringLength(200)]
        public string provincename { get; set; }

        [Required]
        [StringLength(200)]
        public string cityname { get; set; }

        public int sex { get; set; }

        [Required]
        [StringLength(200)]
        public string source { get; set; }

        [Required]
        [StringLength(200)]
        public string fromPcOrMobile { get; set; }

        public int CollectionShopNum { get; set; }

        public int CollectionItemNum { get; set; }

        public int ShoppingCart { get; set; }

        public int Deal { get; set; }

        public decimal DealAmg { get; set; }

        public int shopid { get; set; }

        public long itemid { get; set; }

        public DateTime? PayTime { get; set; }

        [Required]
        [StringLength(200)]
        public string keyword { get; set; }

        public long? tid { get; set; }
    }
}
