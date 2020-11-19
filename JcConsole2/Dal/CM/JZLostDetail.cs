namespace Dal.CM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("JZLostDetail")]
    public partial class JZLostDetail
    {
        public int id { get; set; }

        public DateTime thedate { get; set; }

        public long item { get; set; }

        public long JzItem { get; set; }

        [StringLength(64)]
        public string shopName { get; set; }

        [StringLength(255)]
        public string title { get; set; }

        public decimal? lostData { get; set; }

        public int lostHot { get; set; }

        public decimal? trade { get; set; }

        public int uv { get; set; }

        public int ShopID { get; set; }

        [StringLength(255)]
        public string pic { get; set; }

        public virtual TB_TaobaoShop TB_TaobaoShop { get; set; }
    }
}
