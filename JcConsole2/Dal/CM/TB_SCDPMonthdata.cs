namespace Dal.CM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_SCDPMonthdata
    {
        public int id { get; set; }

        public DateTime date { get; set; }

        public long CateId { get; set; }

        public decimal SearchPerson { get; set; }

        public decimal SearchHot { get; set; }

        public long UV { get; set; }

        public long PV { get; set; }

        public int CollectPerson { get; set; }

        public int CollectNum { get; set; }

        public int AddCarPerson { get; set; }

        public int AddCarNum { get; set; }

        public decimal KeQun { get; set; }

        public decimal Pay { get; set; }

        public decimal? SearchUV { get; set; }

        public decimal? SearchClick { get; set; }

        public decimal? SellerNumber { get; set; }

        public decimal? PayMoney { get; set; }

        public int? slrCntSum { get; set; }

        public int? tradeSlrCnt { get; set; }

        public DateTime CreateTime { get; set; }

        [Required]
        [StringLength(100)]
        public string ShopId { get; set; }

        [Required]
        [StringLength(100)]
        public string CreateUser { get; set; }

        public int SellerType { get; set; }
    }
}
