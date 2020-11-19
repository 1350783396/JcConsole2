namespace Dal.CM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class YSF_dim_pc_src_new_d
    {
        [Key]
        public string src_id { get; set; }

        [StringLength(512)]
        public string src_id_name { get; set; }

        [StringLength(128)]
        public string src_parent_id { get; set; }

        [StringLength(512)]
        public string src_parent_id_name { get; set; }

        public int src_level { get; set; }

        [StringLength(128)]
        public string is_leaf { get; set; }
    }
}
