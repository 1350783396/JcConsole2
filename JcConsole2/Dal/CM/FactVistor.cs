namespace Dal.CM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FactVistor")]
    public partial class FactVistor
    {
        public int id { get; set; }

        public DateTime thedate { get; set; }

        [StringLength(64)]
        public string from { get; set; }

        [StringLength(64)]
        public string keyword { get; set; }

        [StringLength(255)]
        public string pic { get; set; }

        [StringLength(255)]
        public string url { get; set; }

        [StringLength(255)]
        public string title { get; set; }

        public long item { get; set; }

        [StringLength(64)]
        public string place { get; set; }

        public int vistorNum { get; set; }

        public int ShopID { get; set; }

        public virtual TB_TaobaoShop TB_TaobaoShop { get; set; }
    }
}
