namespace Dal.CM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class YSF_shop_src_last_effect_d
    {
        public int id { get; set; }

        public DateTime thedate { get; set; }

        public long seller_id { get; set; }

        public long shop_id { get; set; }

        [StringLength(128)]
        public string src_id { get; set; }

        public int src_level { get; set; }

        [StringLength(128)]
        public string src_parent_id { get; set; }

        public int pv { get; set; }

        public int uv { get; set; }

        public int ipv { get; set; }

        public int iuv { get; set; }

        public decimal bounce_rate { get; set; }

        public int alipay_winner_num { get; set; }

        public int alipay_auction_num { get; set; }

        public decimal alipay_trade_amt { get; set; }

        public int alipay_trade_num { get; set; }

        public int ShopID { get; set; }

        public virtual TB_TaobaoShop TB_TaobaoShop { get; set; }
    }
}
