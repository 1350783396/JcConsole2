namespace Dal.CM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_TaobaoItemInfoMobile
    {
        public int id { get; set; }

        public int alipay_winner_num { get; set; }

        public decimal plot_alipay_trade_amt { get; set; }

        public int iuv { get; set; }

        public int coll { get; set; }

        public decimal noplot_alipay_trade_amt { get; set; }

        public int plot_gmv_auction_num { get; set; }

        public int gmv_auction_num { get; set; }

        public int plot_gmv_trade_num { get; set; }

        public int plot_type { get; set; }

        public int gmv_trade_num { get; set; }

        public decimal alipay_trade_amt { get; set; }

        public int noplot_alipay_auction_num { get; set; }

        public decimal today_trade_amt { get; set; }

        public int noplot_gmv_auction_num { get; set; }

        public int noplot_alipay_trade_num { get; set; }

        public int today_trade_num { get; set; }

        public int ipv { get; set; }

        public decimal noplot_gmv_trade_amt { get; set; }

        public int plot_alipay_auction_num { get; set; }

        public int noplot_gmv_trade_num { get; set; }

        public DateTime day { get; set; }

        public int plot_alipay_trade_num { get; set; }

        public decimal gmv_trade_amt { get; set; }

        public int alipay_auction_num { get; set; }

        public decimal plot_gmv_trade_amt { get; set; }

        public long aucid { get; set; }

        public int today_auction_num { get; set; }

        public int alipay_trade_num { get; set; }

        public decimal avg_acc_time { get; set; }

        [StringLength(64)]
        public string avg_bounce_rate { get; set; }

        public int ShopID { get; set; }

        [StringLength(128)]
        public string UserID { get; set; }

        public virtual TB_TaobaoShop TB_TaobaoShop { get; set; }
    }
}
