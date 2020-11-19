namespace Dal.CM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ApiLogisticsCompany")]
    public partial class ApiLogisticsCompany
    {
        [Key]
        [StringLength(60)]
        public string name { get; set; }

        public long id { get; set; }

        [StringLength(32)]
        public string code { get; set; }
    }
}
