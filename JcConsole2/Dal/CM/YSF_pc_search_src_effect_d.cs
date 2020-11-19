namespace Dal.CM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class YSF_pc_search_src_effect_d
    {
        public int id { get; set; }

        public DateTime thedate { get; set; }

        public long seller_id { get; set; }

        public long shop_id { get; set; }

        public long auction_id { get; set; }

        public int impression { get; set; }

        public int click { get; set; }

        public int uv { get; set; }

        public int direct_alipay_winner_num { get; set; }

        public decimal direct_alipay_trade_amt { get; set; }

        public int direct_alipay_trade_num { get; set; }

        public int direct_alipay_auction_num { get; set; }

        public int ShopID { get; set; }

        public virtual TB_TaobaoShop TB_TaobaoShop { get; set; }
    }
}
