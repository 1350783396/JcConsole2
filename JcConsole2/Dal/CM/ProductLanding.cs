namespace Dal.CM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProductLanding")]
    public partial class ProductLanding
    {
        public int id { get; set; }

        public DateTime? thedate { get; set; }

        public int? value { get; set; }

        public long? shopid { get; set; }

        public int? cid { get; set; }

        public long? itemid { get; set; }
    }
}
