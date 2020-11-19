namespace Dal.CM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ApiItemChange")]
    public partial class ApiItemChange
    {
        public long id { get; set; }

        public long num_iid { get; set; }

        [Required]
        [StringLength(128)]
        public string title { get; set; }

        [StringLength(128)]
        public string old_title { get; set; }

        public int change_title { get; set; }

        [StringLength(128)]
        public string outer_id { get; set; }

        [StringLength(256)]
        public string pic_url { get; set; }

        [StringLength(256)]
        public string old_pic_url { get; set; }

        public int change_pic { get; set; }

        public DateTime modified { get; set; }

        public DateTime old_modified { get; set; }

        public decimal price { get; set; }

        public decimal old_price { get; set; }

        public decimal cost { get; set; }

        public decimal old_cost { get; set; }

        public int change_price { get; set; }

        public DateTime created { get; set; }

        public int ShopID { get; set; }

        public virtual TB_TaobaoShop TB_TaobaoShop { get; set; }
    }
}
