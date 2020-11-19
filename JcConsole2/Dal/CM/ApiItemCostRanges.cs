namespace Dal.CM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ApiItemCostRanges
    {
        public int id { get; set; }

        public long num_iid { get; set; }

        public DateTime? start { get; set; }

        public DateTime? end { get; set; }

        public DateTime modifed { get; set; }

        public decimal cost { get; set; }

        public virtual ApiItem ApiItem { get; set; }
    }
}
