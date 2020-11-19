namespace Dal.CM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ApiSellerCats
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long cid { get; set; }

        public long parent_cid { get; set; }

        [Required]
        [StringLength(256)]
        public string name { get; set; }

        [StringLength(256)]
        public string pic_url { get; set; }

        [StringLength(256)]
        public string type { get; set; }

        public long sort_order { get; set; }

        public int ShopID { get; set; }

        public virtual TB_TaobaoShop TB_TaobaoShop { get; set; }
    }
}
