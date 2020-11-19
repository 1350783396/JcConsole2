namespace Dal.CM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_TaobaoLzDayInfo
    {
        public int id { get; set; }

        public int ShopID { get; set; }

        public DateTime day { get; set; }

        [StringLength(128)]
        public string UserID { get; set; }

        public decimal trade_repeat_rate { get; set; }

        public decimal noplot_alipay_trade_amt { get; set; }

        public int view_repeat { get; set; }

        public int gmv_auction_num { get; set; }

        public int plot_gmv_trade_num { get; set; }

        public decimal shop_trade_ex { get; set; }

        public int gmv_parent_order_num { get; set; }

        public int alipay_winner_num { get; set; }

        public decimal today_trade_amt { get; set; }

        public decimal ipu { get; set; }

        public decimal plot_gmv_trade_amt { get; set; }

        public decimal avg_session_num { get; set; }

        public int gmv_winner_num { get; set; }

        public decimal ext { get; set; }

        public int session_num { get; set; }

        public int noplot_gmv_auction_num { get; set; }

        public decimal plot_alipay_trade_amt { get; set; }

        public int iuv { get; set; }

        public int noplot_alipay_auction_num { get; set; }

        public int coll_num { get; set; }

        public decimal today_pay_rate { get; set; }

        public int plot_gmv_auction_num { get; set; }

        public int alipay_parent_order_num { get; set; }

        public decimal avg_alipay_parent_order_num { get; set; }

        public int trade_repeat { get; set; }

        public decimal avg_trade_num { get; set; }

        public decimal auction_roc { get; set; }

        public decimal avg_winner_num { get; set; }

        public int gmv_trade_num { get; set; }

        public decimal alipay_trade_amt { get; set; }

        public decimal succ_trade_amt { get; set; }

        public int plot_alipay_trade_num { get; set; }

        public decimal view_repeat_rate { get; set; }

        public int noplot_alipay_trade_num { get; set; }

        public int today_trade_num { get; set; }

        public int plot_alipay_auction_num { get; set; }

        public int alipay_trade_num { get; set; }

        public int today_order_num { get; set; }

        public decimal roc { get; set; }

        public int pv { get; set; }

        public decimal noplot_gmv_trade_amt { get; set; }

        public decimal gmv_trade_amt { get; set; }

        public int today_auction_num { get; set; }

        public int noplot_gmv_trade_num { get; set; }

        public int ipv { get; set; }

        public int uv { get; set; }

        public int alipay_auction_num { get; set; }

        public virtual TB_TaobaoShop TB_TaobaoShop { get; set; }
    }
}
