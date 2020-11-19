namespace Dal.CM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PM_HISTORY
    {
        public int id { get; set; }

        public long? item { get; set; }

        [Column(TypeName = "date")]
        public DateTime? thedate { get; set; }

        [StringLength(64)]
        public string word { get; set; }

        [StringLength(255)]
        public string wordhash { get; set; }

        public byte? mobile { get; set; }

        public int? pm { get; set; }
    }
}
