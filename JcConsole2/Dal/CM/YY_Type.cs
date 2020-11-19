namespace Dal.CM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class YY_Type
    {
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string Type { get; set; }
    }
}
