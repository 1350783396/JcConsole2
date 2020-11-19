namespace Dal.CM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_TaobaoSimbaToday
    {
        public int id { get; set; }

        public decimal effect_rank { get; set; }

        public decimal alipay_indirect_amt { get; set; }

        public int coll_num { get; set; }

        public int adgroup_id { get; set; }

        public int impression { get; set; }

        public decimal efficiency { get; set; }

        public int alipay_indirect { get; set; }

        public int shop_coll_num { get; set; }

        public decimal roc { get; set; }

        public int inner_ipv { get; set; }

        public int alipay_num { get; set; }

        public decimal alipay_amt { get; set; }

        public int finclick { get; set; }

        public long auction_id { get; set; }

        public decimal alipay_direct_amt { get; set; }

        [StringLength(255)]
        public string imgurl { get; set; }

        public int alipay_direct_num { get; set; }

        public int campaign_id { get; set; }

        [StringLength(255)]
        public string auction_name { get; set; }

        public int item_coll_num { get; set; }

        public decimal finprice { get; set; }

        public DateTime day { get; set; }

        public int ShopID { get; set; }

        public virtual TB_TaobaoShop TB_TaobaoShop { get; set; }
    }
}
