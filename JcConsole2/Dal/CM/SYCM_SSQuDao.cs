namespace Dal.CM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SYCM_SSQuDao
    {
        public int id { get; set; }

        public long item { get; set; }

        public long ShopId { get; set; }

        public DateTime thedate { get; set; }

        public string pageName { get; set; }

        public int uv { get; set; }

        public decimal uvR { get; set; }

        public int pageLevel { get; set; }

        public int selfItemUv { get; set; }

        public string pageId { get; set; }

        public decimal selfItemUvR { get; set; }
    }
}
