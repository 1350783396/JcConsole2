namespace Dal.CM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_TaobaoDDS
    {
        public int id { get; set; }

        public int adPv { get; set; }

        public long advertiserId { get; set; }

        public int alipayInShopNum { get; set; }

        public int campaignId { get; set; }

        [StringLength(255)]
        public string campaignName { get; set; }

        public decimal charge { get; set; }

        public int click { get; set; }

        public int dirShopColNum { get; set; }

        public int inshopItemColNum { get; set; }

        public DateTime day { get; set; }

        public int ShopID { get; set; }

        public virtual TB_TaobaoShop TB_TaobaoShop { get; set; }
    }
}
