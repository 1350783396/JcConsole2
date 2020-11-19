namespace Dal.CM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_TaobaoItemVCus
    {
        public int id { get; set; }

        public DateTime day { get; set; }

        public int ViewCount { get; set; }

        public int LoseCount { get; set; }

        public int SuccessCount { get; set; }

        public long ItemId { get; set; }

        public int ShopID { get; set; }

        public virtual TB_TaobaoShop TB_TaobaoShop { get; set; }
    }
}
