namespace Dal.CM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_TaobaoAllCartCollect
    {
        public int id { get; set; }

        public int flag { get; set; }

        public long auctionId { get; set; }

        [StringLength(255)]
        public string itemTitle { get; set; }

        public int stock { get; set; }

        public int newCart { get; set; }

        public int totalCart { get; set; }

        public int newCollection { get; set; }

        public int totalCollection { get; set; }

        public int ipv { get; set; }

        public int iuv { get; set; }

        [StringLength(255)]
        public string picUrl { get; set; }

        public int warning { get; set; }

        public int isActive { get; set; }

        public string new_cartJson { get; set; }

        public string new_collectJson { get; set; }

        public DateTime day { get; set; }

        public int ShopID { get; set; }

        public virtual TB_TaobaoShop TB_TaobaoShop { get; set; }
    }
}
