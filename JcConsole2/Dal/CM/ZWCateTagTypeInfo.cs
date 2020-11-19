namespace Dal.CM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ZWCateTagTypeInfo")]
    public partial class ZWCateTagTypeInfo
    {
        public int ID { get; set; }

        [StringLength(64)]
        public string keyword { get; set; }

        public long? ShopID { get; set; }

        public long? CateID { get; set; }

        public int? TypeID { get; set; }

        public int? SecondTypeID { get; set; }

        public int? rank { get; set; }

        public decimal? searchAddRange { get; set; }

        public int? searchPv { get; set; }

        public int? clickPv { get; set; }

        public decimal? clickPercent { get; set; }

        public decimal? payPercent { get; set; }

        public int? searchNum { get; set; }

        public int? clickNum { get; set; }

        public int? payNum { get; set; }

        public DateTime? EndDate { get; set; }

        public int? dataRangeNumber { get; set; }

        public DateTime? CreateTime { get; set; }

        [StringLength(100)]
        public string CreateUser { get; set; }
    }
}
