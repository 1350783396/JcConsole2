namespace Dal.CM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_TaobaoMonthCost
    {
        public int id { get; set; }

        public DateTime? thedate { get; set; }

        public long? iuv { get; set; }

        public long? alipay_winner_num { get; set; }

        public decimal? alipay_trade_amt { get; set; }

        public decimal? pay_conversion_rate { get; set; }

        public decimal? item_amount { get; set; }

        public decimal? succ_refund_trade_amt { get; set; }

        public int? brush_single_num { get; set; }

        public decimal? re_order_amount { get; set; }

        public decimal? re_order_cost { get; set; }

        public decimal? Express_cost { get; set; }

        public decimal? sp_Recommend_cost { get; set; }

        public decimal? dm_Exhibition_cost { get; set; }

        public decimal? Taoke_cost { get; set; }

        public decimal? other_cost { get; set; }

        public int? shopid { get; set; }
    }
}
