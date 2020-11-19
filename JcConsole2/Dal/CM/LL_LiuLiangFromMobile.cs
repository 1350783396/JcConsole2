namespace Dal.CM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LL_LiuLiangFromMobile
    {
        public int id { get; set; }

        public int pv { get; set; }

        public int uv { get; set; }

        public decimal alipayTradeAmt { get; set; }

        public int alipayWinnerNum { get; set; }

        [StringLength(64)]
        public string srcName { get; set; }

        public DateTime day { get; set; }

        public int srcId { get; set; }

        public decimal roc { get; set; }

        public int srcParentId { get; set; }

        public int srcLevel { get; set; }

        public int alipayAuctionNum { get; set; }

        public int gmvAuctionNum { get; set; }

        public decimal gmvTradeAmt { get; set; }

        public decimal bounceRate { get; set; }

        public int hasDiamond { get; set; }

        public decimal chainRoc { get; set; }

        public int isNew { get; set; }

        public int ShopID { get; set; }

        public virtual TB_TaobaoShop TB_TaobaoShop { get; set; }
    }
}
