namespace Dal.CM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_TaoBaoCustomizeCategory
    {
        public int id { get; set; }

        [StringLength(50)]
        public string CategoryName { get; set; }

        [StringLength(50)]
        public string CategoryID { get; set; }

        [StringLength(50)]
        public string FromTable { get; set; }

        [StringLength(50)]
        public string keyWord { get; set; }

        public bool? IsInitialize { get; set; }

        [StringLength(50)]
        public string Correlation_ID { get; set; }

        [StringLength(50)]
        public string keyName { get; set; }

        public decimal? Target { get; set; }

        public int? parentID { get; set; }

        public int? SortBy { get; set; }

        public bool? AvgOrSum { get; set; }
    }
}
