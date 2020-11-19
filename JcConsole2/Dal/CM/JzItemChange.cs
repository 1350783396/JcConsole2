namespace Dal.CM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("JzItemChange")]
    public partial class JzItemChange
    {
        public int id { get; set; }

        public long jzItem { get; set; }

        [Required]
        [StringLength(60)]
        public string title { get; set; }

        [Required]
        [StringLength(600)]
        public string pic { get; set; }

        public int? commentCount { get; set; }

        public int? favcount { get; set; }

        public int? sellCount { get; set; }

        [StringLength(100)]
        public string price { get; set; }

        [StringLength(2000)]
        public string shopProm { get; set; }

        public DateTime createTime { get; set; }

        public DateTime updateTime { get; set; }
    }
}
