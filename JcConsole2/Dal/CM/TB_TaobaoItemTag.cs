namespace Dal.CM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_TaobaoItemTag
    {
        public int id { get; set; }

        [Required]
        [StringLength(255)]
        public string kind { get; set; }

        [StringLength(255)]
        public string tag { get; set; }

        public string names { get; set; }

        public DateTime created { get; set; }

        public int ShopID { get; set; }

        public virtual TB_TaobaoShop TB_TaobaoShop { get; set; }
    }
}
