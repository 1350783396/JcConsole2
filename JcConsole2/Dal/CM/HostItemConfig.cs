namespace Dal.CM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HostItemConfig")]
    public partial class HostItemConfig
    {
        public int id { get; set; }

        [StringLength(50)]
        public string name { get; set; }

        public byte? days { get; set; }

        [StringLength(500)]
        public string rate_arry { get; set; }

        [StringLength(1000)]
        public string remark { get; set; }

        [StringLength(1000)]
        public string warning { get; set; }

        public bool ruanning { get; set; }

        public int? isShow { get; set; }
    }
}
