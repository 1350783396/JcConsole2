namespace Dal.CM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ApiItemSkuCostRanges
    {
        public int id { get; set; }

        public long num_iid { get; set; }

        public long sku_id { get; set; }

        public int costRange { get; set; }

        public DateTime modifed { get; set; }

        public decimal cost { get; set; }

        public virtual ApiItem ApiItem { get; set; }

        public virtual ApiSkus ApiSkus { get; set; }
    }
}
