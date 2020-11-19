namespace Dal.CM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class YSF_new_shop_weblog_d
    {
        public int id { get; set; }

        public DateTime thedate { get; set; }

        [StringLength(256)]
        public string time_stamp { get; set; }

        public long seller_id { get; set; }

        public long shop_id { get; set; }

        [StringLength(256)]
        public string buyer_id { get; set; }

        [StringLength(256)]
        public string user_agent { get; set; }

        [StringLength(256)]
        public string user_ip { get; set; }

        [StringLength(256)]
        public string acookie { get; set; }

        [StringLength(256)]
        public string lz_session { get; set; }

        [StringLength(256)]
        public string access_url { get; set; }

        [StringLength(256)]
        public string refer_url { get; set; }

        [StringLength(256)]
        public string url_title { get; set; }

        public long is_member { get; set; }

        [StringLength(256)]
        public string aid { get; set; }

        public long auction_id { get; set; }

        public int ShopID { get; set; }

        public virtual TB_TaobaoShop TB_TaobaoShop { get; set; }
    }
}
