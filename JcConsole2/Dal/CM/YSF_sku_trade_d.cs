namespace Dal.CM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class YSF_sku_trade_d
    {
        public int id { get; set; }

        public DateTime thedate { get; set; }

        public long shop_id { get; set; }

        public long seller_id { get; set; }

        public long sku_id { get; set; }

        public long alipay_trade_num { get; set; }

        public long alipay_auction_num { get; set; }

        public decimal alipay_trade_amt { get; set; }

        public long alipay_winner_num { get; set; }

        public long gmv_auction_num { get; set; }

        public decimal gmv_trade_amt { get; set; }

        public long gmv_trade_num { get; set; }

        public long gmv_winner_num { get; set; }

        public long add_cart_user_num { get; set; }

        public decimal succ_refund_trade_amt { get; set; }

        public long sku_stock { get; set; }

        public int ShopID { get; set; }

        public long auction_id { get; set; }

        [StringLength(255)]
        public string sku_prpt { get; set; }

        public virtual TB_TaobaoShop TB_TaobaoShop { get; set; }
    }
}
