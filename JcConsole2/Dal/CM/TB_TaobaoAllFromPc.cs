namespace Dal.CM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_TaobaoAllFromPc
    {
        public int id { get; set; }

        public int ShopID { get; set; }

        public DateTime day { get; set; }

        public int level { get; set; }

        public int new_uv { get; set; }

        public int uv { get; set; }

        public int landing_pv { get; set; }

        public decimal avg_pv { get; set; }

        public decimal bounce_rate { get; set; }

        public decimal percent_landing_pv { get; set; }

        [StringLength(64)]
        public string src_name { get; set; }

        public decimal percent_pv { get; set; }

        public int pv { get; set; }

        public decimal percent_new_uv { get; set; }

        public int src_id { get; set; }

        public int src_parent_id { get; set; }

        public virtual TB_TaobaoShop TB_TaobaoShop { get; set; }
    }
}
