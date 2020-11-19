namespace Dal.CM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_TaobaoItemExt
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Item { get; set; }

        [StringLength(2000)]
        public string simbaDayUrl { get; set; }

        public int ShopID { get; set; }

        public virtual TB_TaobaoShop TB_TaobaoShop { get; set; }
    }
}
