namespace Dal.CM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class YSF_auction_comment_d
    {
        public int id { get; set; }

        public DateTime thedate { get; set; }

        public long shop_id { get; set; }

        public long seller_id { get; set; }

        public short? shop_type { get; set; }

        public long auction_id { get; set; }

        public int sys_def_pos_comt_tra_num { get; set; }

        public int pos_comt_trade_num { get; set; }

        public int mid_comt_trade_num { get; set; }

        public int neg_comt_trade_num { get; set; }

        public int comt_trade_num { get; set; }

        public decimal dsr_qual_score_sub { get; set; }

        public int dsr_qual_comt_cnt_sub { get; set; }

        public decimal dsr_qual_score { get; set; }

        public int dsr_qual_comt_cnt { get; set; }

        public decimal dsr_serv_score { get; set; }

        public int dsr_serv_comt_cnt { get; set; }

        public decimal dsr_deli_score { get; set; }

        public int dsr_deli_comt_cnt { get; set; }

        public decimal dsr_logi_score { get; set; }

        public int dsr_logi_comt_cnt { get; set; }

        public int ShopID { get; set; }

        public virtual TB_TaobaoShop TB_TaobaoShop { get; set; }
    }
}
