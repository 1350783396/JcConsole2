namespace Dal.CM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_TaobaoItem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Item { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        [StringLength(400)]
        public string Url { get; set; }

        [StringLength(400)]
        public string PicUrl { get; set; }

        public decimal Price { get; set; }

        public decimal GetMoney { get; set; }

        public decimal ExpressMoney { get; set; }

        public int Order { get; set; }

        public bool IsHidden { get; set; }

        public DateTime? CreateDate { get; set; }

        [StringLength(128)]
        public string CreateID { get; set; }

        public int ShopID { get; set; }

        [StringLength(255)]
        public string WordsTitle { get; set; }

        [StringLength(128)]
        public string Words { get; set; }

        public DateTime? LastWords { get; set; }

        public decimal? factZh { get; set; }

        public decimal? factIndustryP { get; set; }

        public Guid? uid { get; set; }

        public long? tacticsJZitem { get; set; }

        public DateTime? tacticState { get; set; }

        public DateTime? tacticEnd { get; set; }

        public virtual TB_TaobaoShop TB_TaobaoShop { get; set; }
    }
}
