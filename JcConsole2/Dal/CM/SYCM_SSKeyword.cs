namespace Dal.CM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SYCM_SSKeyword
    {
        public int id { get; set; }

        public long item { get; set; }

        public long ShopId { get; set; }

        public DateTime thedate { get; set; }

        public string keywork { get; set; }

        public int? uv { get; set; }
    }
}
