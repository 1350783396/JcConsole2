namespace Dal.CM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ShopSort")]
    public partial class ShopSort
    {
        public int id { get; set; }

        [StringLength(50)]
        public string tName { get; set; }

        public DateTime? thedate { get; set; }

        public string remark { get; set; }

        [StringLength(300)]
        public string colour { get; set; }

        [StringLength(50)]
        public string icon { get; set; }

        public int? isHide { get; set; }

        public long? shopid { get; set; }

        public int? isdelete { get; set; }
    }
}
