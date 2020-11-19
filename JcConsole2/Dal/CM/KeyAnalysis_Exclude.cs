namespace Dal.CM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class KeyAnalysis_Exclude
    {
        public int id { get; set; }

        public int TaskId { get; set; }

        public decimal ExcludeNumber { get; set; }

        public int device { get; set; }

        public int ExcludeType { get; set; }

        public long item_id { get; set; }

        public DateTime thedate { get; set; }
    }
}
