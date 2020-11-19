namespace Dal.CM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class YSF_item_search_effect_new_d
    {
        public int id { get; set; }

        public DateTime thedate { get; set; }

        public long seller_id { get; set; }

        public long shop_id { get; set; }

        public long item_id { get; set; }

        [StringLength(128)]
        public string keyword { get; set; }

        public long avg_search_rank { get; set; }

        public long imps_cnt { get; set; }

        public long clk_cnt { get; set; }

        public decimal clk_rate { get; set; }

        public long landing_uv { get; set; }

        public long landing_cnt { get; set; }

        public decimal avg_visit_pv_holotree { get; set; }

        public long bounce_cnt_holotree { get; set; }

        public decimal bounce_rate_holotree { get; set; }

        public long crt_ord_item_cnt_holotree_allbe_directbe { get; set; }

        public long crt_ord_item_qty_holotree_allbe_directbe { get; set; }

        public decimal crt_ord_amt_holotree_allbe_directbe { get; set; }

        public long crt_ord_byr_cnt_holotree_allbe_directbe { get; set; }

        public long crt_ord_cnt_holotree_allbe_directbe { get; set; }

        public long crt_mord_cnt_holotree_allbe_directbe { get; set; }

        public long pay_ord_item_cnt_holotree_allbe_directbe { get; set; }

        public long pay_ord_item_qty_holotree_allbe_directbe { get; set; }

        public decimal pay_ord_amt_holotree_allbe_directbe { get; set; }

        public long pay_ord_byr_cnt_holotree_allbe_directbe { get; set; }

        public long pay_ord_cnt_holotree_allbe_directbe { get; set; }

        public long pay_mord_holotree_allbe_directbe { get; set; }

        public decimal vst_pay_byr_rate_holotree_allbe_directbe { get; set; }

        public decimal crt_pay_byr_rate_holotree_allbe_directbe { get; set; }

        public long crt_ord_item_cnt_holotree_allbe_indirectbe { get; set; }

        public long crt_ord_item_qty_holotree_allbe_indirectbe { get; set; }

        public decimal crt_ord_amt_holotree_allbe_indirectbe { get; set; }

        public long crt_ord_byr_cnt_holotree_allbe_indirectbe { get; set; }

        public long crt_ord_cnt_holotree_allbe_indirectbe { get; set; }

        public long crt_mord_cnt_holotree_allbe_indirectbe { get; set; }

        public long pay_ord_item_cnt_holotree_allbe_indirectbe { get; set; }

        public long pay_ord_item_qty_holotree_allbe_indirectbe { get; set; }

        public decimal pay_ord_amt_holotree_allbe_indirectbe { get; set; }

        public long pay_ord_byr_cnt_holotree_allbe_indirectbe { get; set; }

        public long pay_ord_cnt_holotree_allbe_indirectbe { get; set; }

        public long pay_mord_holotree_allbe_indirectbe { get; set; }

        public decimal vst_pay_byr_rate_holotree_allbe_indirectbe { get; set; }

        public decimal crt_pay_byr_rate_holotree_allbe_indirectbe { get; set; }

        public long crt_ord_item_cnt_holotree_allbe_guide { get; set; }

        public long crt_ord_item_qty_holotree_allbe_guide { get; set; }

        public decimal crt_ord_amt_holotree_allbe_guide { get; set; }

        public long crt_ord_byr_cnt_holotree_allbe_guide { get; set; }

        public long crt_ord_cnt_holotree_allbe_guide { get; set; }

        public long crt_mord_cnt_holotree_allbe_guide { get; set; }

        public long pay_ord_item_cnt_holotree_allbe_guide { get; set; }

        public long pay_ord_item_qty_holotree_allbe_guide { get; set; }

        public decimal pay_ord_amt_holotree_allbe_guide { get; set; }

        public long pay_ord_byr_cnt_holotree_allbe_guide { get; set; }

        public long pay_ord_cnt_holotree_allbe_guide { get; set; }

        public long pay_mord_holotree_allbe_guide { get; set; }

        public decimal vst_pay_byr_rate_holotree_allbe_guide { get; set; }

        public decimal crt_pay_byr_rate_holotree_allbe_guide { get; set; }

        public long shop_clt_cnt { get; set; }

        public long item_clt_cnt { get; set; }

        public long cart_item_qty { get; set; }

        public int ShopID { get; set; }

        public string remarks { get; set; }

        public bool? bNew { get; set; }

        public virtual TB_TaobaoShop TB_TaobaoShop { get; set; }
    }
}
