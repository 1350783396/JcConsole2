namespace Dal.CM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_TaobaoAllFromMobile
    {
        public int id { get; set; }

        public int ShopID { get; set; }

        public DateTime day { get; set; }

        public int iuv { get; set; }

        public decimal trade_repeat_rate { get; set; }

        public int trade_repeat_num { get; set; }

        public int gmv_auction_num { get; set; }

        public int wireless_platform { get; set; }

        public int view_repeat_num { get; set; }

        public int gmv_trade_num { get; set; }

        public decimal per_visit_depth { get; set; }

        public int alipay_winner_num { get; set; }

        public decimal alipay_convert { get; set; }

        public decimal same_day_trade_rate { get; set; }

        public int uv { get; set; }

        public int same_day_trade_num { get; set; }

        public int ipv { get; set; }

        public decimal same_day_trade_amt { get; set; }

        public int same_day_auction_num { get; set; }

        public decimal per_user_alipay_amt { get; set; }

        public decimal alipay_trade_amt { get; set; }

        public int alipay_trade_num { get; set; }

        public decimal gmv_trade_amt { get; set; }

        public int view_repeat_rate { get; set; }

        public int pv { get; set; }

        [StringLength(64)]
        public string name { get; set; }

        public int alipay_auction_num { get; set; }

        public virtual TB_TaobaoShop TB_TaobaoShop { get; set; }
    }
}
