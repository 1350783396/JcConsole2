namespace Dal.CM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_TaobaoAllTopMobile
    {
        public int id { get; set; }

        public int ShopID { get; set; }

        public DateTime day { get; set; }

        public int alipay_winner_num { get; set; }

        public int iuv { get; set; }

        public decimal alipay_trade_amt { get; set; }

        public int today_trade_num { get; set; }

        public int alipay_trade_num { get; set; }

        public decimal roc { get; set; }

        public int ipv { get; set; }

        public virtual TB_TaobaoShop TB_TaobaoShop { get; set; }
    }
}
