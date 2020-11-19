namespace Dal.CM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class YSF_auction_app_query_effect_new_d
    {
        public int id { get; set; }

        public DateTime thedate { get; set; }

        public long seller_id { get; set; }

        public long shop_id { get; set; }

        public long item_id { get; set; }

        [StringLength(128)]
        public string keyword { get; set; }

        public long landing_cnt { get; set; }

        public long landing_uv { get; set; }

        public long crt_ord_byr_cnt_holotree_lastbe_directbe { get; set; }

        public long crt_ord_cnt_holotree_lastbe_directbe { get; set; }

        public decimal crt_ord_amt_holotree_lastbe_directbe { get; set; }

        public long crt_ord_item_cnt_holotree_lastbe_directbe { get; set; }

        public long pay_ord_byr_cnt_holotree_lastbe_directbe { get; set; }

        public long pay_ord_cnt_holotree_lastbe_directbe { get; set; }

        public decimal pay_ord_amt_holotree_lastbe_directbe { get; set; }

        public long pay_ord_item_cnt_holotree_lastbe_directbe { get; set; }

        public long crt_ord_byr_cnt_holotree_lastbe_indirectbe { get; set; }

        public long crt_ord_cnt_holotree_lastbe_indirectbe { get; set; }

        public decimal crt_ord_amt_holotree_lastbe_indirectbe { get; set; }

        public long crt_ord_item_cnt_holotree_lastbe_indirectbe { get; set; }

        public long pay_ord_byr_cnt_holotree_lastbe_indirectbe { get; set; }

        public long pay_ord_cnt_holotree_lastbe_indirectbe { get; set; }

        public decimal pay_ord_amt_holotree_lastbe_indirectbe { get; set; }

        public long pay_ord_item_cnt_holotree_lastbe_indirectbe { get; set; }

        public int ShopID { get; set; }

        public string remarks { get; set; }

        public bool? bNew { get; set; }

        public int? shopInnerTCount { get; set; }

        public int? tShopCount { get; set; }

        public int? collect { get; set; }

        public int? shopCat { get; set; }

        public virtual TB_TaobaoShop TB_TaobaoShop { get; set; }
    }
}
