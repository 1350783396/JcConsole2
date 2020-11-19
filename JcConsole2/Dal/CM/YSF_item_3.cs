namespace Dal.CM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class YSF_item_3
    {
        public int id { get; set; }

        public DateTime thedate { get; set; }

        public long shop_id { get; set; }

        public long seller_id { get; set; }

        public long auction_id { get; set; }

        public int iuv { get; set; }

        public int ipv { get; set; }

        public int page_duration { get; set; }

        public int bounce_cnt { get; set; }

        public int landing_cnt { get; set; }

        public int landing_uv { get; set; }

        public int exit_cnt { get; set; }

        public int auction_collect_num { get; set; }

        public decimal auction_price { get; set; }

        public int alipay_trade_num { get; set; }

        public int alipay_auction_num { get; set; }

        public decimal alipay_trade_amt { get; set; }

        public int alipay_winner_num { get; set; }

        public int gmv_auction_num { get; set; }

        public decimal gmv_trade_amt { get; set; }

        public int gmv_trade_num { get; set; }

        public int gmv_winner_num { get; set; }

        public int same_day_trade_num { get; set; }

        public decimal same_day_trade_amt { get; set; }

        public int same_day_auction_num { get; set; }

        public int plot_gmv_trade_num { get; set; }

        public decimal plot_gmv_trade_amt { get; set; }

        public int plot_gmv_auction_num { get; set; }

        public int noplot_gmv_trade_num { get; set; }

        public decimal noplot_gmv_trade_amt { get; set; }

        public int noplot_gmv_auction_num { get; set; }

        public int plot_alipay_trade_num { get; set; }

        public decimal plot_alipay_trade_amt { get; set; }

        public int plot_alipay_auction_num { get; set; }

        public int noplot_alipay_trade_num { get; set; }

        public decimal noplot_alipay_trade_amt { get; set; }

        public int noplot_alipay_auction_num { get; set; }

        public int add_cart_user_num { get; set; }

        public decimal succ_refund_trade_amt { get; set; }

        public int succ_trade_num { get; set; }

        public int alipay_order_num { get; set; }

        public int gmv_order_num { get; set; }

        public decimal bounce_rate { get; set; }

        public int ShopID { get; set; }

        public int filtrate_PV_PC { get; set; }

        public int filtrate_PV_Mobile { get; set; }

        public int filtrate_Base_Turnover_PC { get; set; }

        public int filtrate_Base_Turnover_Mobile { get; set; }

        public int filtrate_Other_Turnover_PC { get; set; }

        public int filtrate_Other_Turnover_Mobile { get; set; }

        public int filtrate_ShopCar_PC { get; set; }

        public int filtrate_ShopCar_Mobile { get; set; }

        public virtual TB_TaobaoShop TB_TaobaoShop { get; set; }
    }
}
