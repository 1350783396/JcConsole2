namespace Dal.CM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SYCM_ShiChangDaPan
    {
        public int id { get; set; }

        public DateTime date { get; set; }

        public long CateId { get; set; }

        public decimal SearchPerson { get; set; }

        public decimal SearchHot { get; set; }

        public int UV { get; set; }

        public int CollectPerson { get; set; }

        public int CollectNum { get; set; }

        public int AddCarPerson { get; set; }

        public int AddCarNum { get; set; }

        public decimal KeQun { get; set; }

        public decimal Pay { get; set; }

        public DateTime CreateTime { get; set; }

        [Required]
        [StringLength(100)]
        public string ShopId { get; set; }

        [Required]
        [StringLength(100)]
        public string CreateUser { get; set; }

        public int PV { get; set; }
    }
}
