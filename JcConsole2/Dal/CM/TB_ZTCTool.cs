namespace Dal.CM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_ZTCTool
    {
        public int id { get; set; }

        [Required]
        [StringLength(64)]
        public string keyword { get; set; }

        [Required]
        public string liuliang { get; set; }

        public decimal showPercent { get; set; }

        public int showIndex { get; set; }

        public int clickIndex { get; set; }

        public decimal clickPercent { get; set; }

        public decimal price { get; set; }

        public int jz { get; set; }

        public decimal clickChangeP { get; set; }

        [Required]
        public string area { get; set; }

        public string areaJson { get; set; }

        public DateTime? CreateDate { get; set; }

        public int ShopID { get; set; }

        public string clicks { get; set; }

        public string clicksJson { get; set; }

        public virtual TB_TaobaoShop TB_TaobaoShop { get; set; }
    }
}
