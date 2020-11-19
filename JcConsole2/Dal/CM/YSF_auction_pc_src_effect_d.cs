namespace Dal.CM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class YSF_auction_pc_src_effect_d
    {
        public int id { get; set; }

        public DateTime thedate { get; set; }

        public long seller_id { get; set; }

        public long shop_id { get; set; }

        public long auction_id { get; set; }

        public int src_id { get; set; }

        public int src_level { get; set; }

        public int src_parent_id { get; set; }

        public int iuv { get; set; }

        public int ipv { get; set; }

        public int alipay_trade_num { get; set; }

        public int alipay_auction_num { get; set; }

        public decimal alipay_trade_amt { get; set; }

        public int alipay_winner_num { get; set; }

        public int gmv_trade_num { get; set; }

        public int gmv_auction_num { get; set; }

        public decimal gmv_trade_amt { get; set; }

        public int gmv_winner_num { get; set; }

        public int ShopID { get; set; }

        public virtual TB_TaobaoShop TB_TaobaoShop { get; set; }
    }
}
