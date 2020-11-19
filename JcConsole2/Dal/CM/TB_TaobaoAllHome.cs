namespace Dal.CM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_TaobaoAllHome
    {
        public int id { get; set; }

        public int ShopID { get; set; }

        public DateTime day { get; set; }

        public int out_ss { get; set; }

        public int avg_time { get; set; }

        public int boc_ss { get; set; }

        public int uv_times { get; set; }

        public int pv_times { get; set; }

        public int click { get; set; }

        public int in_ss { get; set; }

        public virtual TB_TaobaoShop TB_TaobaoShop { get; set; }
    }
}
