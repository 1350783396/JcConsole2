namespace Dal.CM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ItemConversionRate")]
    public partial class ItemConversionRate
    {
        [StringLength(50)]
        public string Id { get; set; }

        public long? item { get; set; }

        [StringLength(10)]
        public string value { get; set; }

        [StringLength(50)]
        public string userId { get; set; }
    }
}
