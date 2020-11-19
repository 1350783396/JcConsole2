namespace Dal.CM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SPShopConfig")]
    public partial class SPShopConfig
    {
        public int id { get; set; }

        public long itemid { get; set; }

        public int cid { get; set; }
    }
}
