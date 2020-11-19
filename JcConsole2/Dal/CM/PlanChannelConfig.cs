namespace Dal.CM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PlanChannelConfig")]
    public partial class PlanChannelConfig
    {
        public int id { get; set; }

        [StringLength(200)]
        public string name { get; set; }

        [StringLength(500)]
        public string remark { get; set; }
    }
}
