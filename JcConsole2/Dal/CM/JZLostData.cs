namespace Dal.CM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("JZLostData")]
    public partial class JZLostData
    {
        public int id { get; set; }

        public DateTime thedate { get; set; }

        public int pm { get; set; }

        public long item { get; set; }

        public decimal payLostAmt { get; set; }

        public int losByrCnt { get; set; }

        public decimal losRate { get; set; }

        public int cltLosByrCnt { get; set; }

        public int cartLosByrCnt { get; set; }

        public int cltJmpByrCnt { get; set; }

        public int cartJmpByrCnt { get; set; }

        public int directLosCnt { get; set; }

        public int losItmCnt { get; set; }

        public int losShopCnt { get; set; }

        public int ShopID { get; set; }

        public virtual TB_TaobaoShop TB_TaobaoShop { get; set; }
    }
}
