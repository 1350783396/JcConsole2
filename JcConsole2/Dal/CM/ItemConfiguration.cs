namespace Dal.CM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ItemConfiguration")]
    public partial class ItemConfiguration
    {
        public int id { get; set; }

        public int shopid { get; set; }

        public long itemid { get; set; }

        public decimal? industry_rate { get; set; }

        public decimal? search_rate { get; set; }

        public decimal? brush_single_rate { get; set; }
    }
}
