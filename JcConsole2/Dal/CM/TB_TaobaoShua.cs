namespace Dal.CM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_TaobaoShua
    {
        public int id { get; set; }

        public DateTime day { get; set; }

        public int ShuaCount { get; set; }

        public decimal ShuaMoney { get; set; }

        public long ItemId { get; set; }

        public DateTime CreateDate { get; set; }

        public int ShopID { get; set; }

        public virtual TB_TaobaoShop TB_TaobaoShop { get; set; }
    }
}
