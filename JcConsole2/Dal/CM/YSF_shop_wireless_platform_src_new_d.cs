namespace Dal.CM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class YSF_shop_wireless_platform_src_new_d
    {
        public int id { get; set; }

        public DateTime thedate { get; set; }

        public long shop_id { get; set; }

        public long seller_id { get; set; }

        [StringLength(64)]
        public string platform_id { get; set; }

        [StringLength(64)]
        public string src_id { get; set; }

        [StringLength(64)]
        public string src_parent_id { get; set; }

        public long src_level { get; set; }

        public long pv { get; set; }

        public long uv { get; set; }

        public long ipv { get; set; }

        public long iuv { get; set; }

        public long crt_ord_byr_cnt_holotree_lastbe_guide { get; set; }

        public decimal crt_ord_amt_holotree_lastbe_guide { get; set; }

        public long crt_ord_cnt_holotree_lastbe_guide { get; set; }

        public long crt_ord_item_qty_holotree_lastbe_guide { get; set; }

        public long pay_ord_byr_cnt_holotree_lastbe_guide { get; set; }

        public decimal pay_ord_amt_holotree_lastbe_guide { get; set; }

        public long pay_ord_cnt_holotree_lastbe_guide { get; set; }

        public long pay_ord_item_qty_holotree_lastbe_guide { get; set; }

        public int ShopID { get; set; }

        public virtual TB_TaobaoShop TB_TaobaoShop { get; set; }
    }
}
