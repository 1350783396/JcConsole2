namespace Dal.CM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ApiItemCats
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long id { get; set; }

        public long parent_cid { get; set; }

        [Required]
        [StringLength(64)]
        public string name { get; set; }

        public bool is_parent { get; set; }

        [StringLength(32)]
        public string status { get; set; }

        public int sort_order { get; set; }
    }
}
