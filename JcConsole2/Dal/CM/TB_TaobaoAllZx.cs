namespace Dal.CM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_TaobaoAllZx
    {
        public int id { get; set; }

        public int ShopID { get; set; }

        public DateTime day { get; set; }

        public decimal ClickP { get; set; }

        public decimal ViewP { get; set; }

        public int AvgTime { get; set; }

        public decimal AvgDepht { get; set; }

        public decimal SuccessP { get; set; }

        public decimal NewAutoP { get; set; }

        public decimal ReAutoP { get; set; }

        public decimal CollCount { get; set; }

        public decimal HomeBoundRate { get; set; }

        public decimal HomeNewClick { get; set; }

        public virtual TB_TaobaoShop TB_TaobaoShop { get; set; }
    }
}
