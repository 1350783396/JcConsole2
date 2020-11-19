namespace Dal.CM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SYCM_SCPHPinPai
    {
        public int id { get; set; }

        public DateTime thedate { get; set; }

        public long BrandId { get; set; }

        [Required]
        [StringLength(50)]
        public string BrandName { get; set; }

        [Required]
        [StringLength(100)]
        public string Logo { get; set; }

        public int uvIndex { get; set; }

        public decimal tradeIndex { get; set; }

        public int seIpvUvHits { get; set; }

        public decimal payRateIndex { get; set; }

        public int uv { get; set; }

        public decimal Pay { get; set; }

        public decimal Android { get; set; }

        public int landinguv { get; set; }

        public decimal payPercent { get; set; }

        public int payBuyerCount { get; set; }

        public decimal landingUvRatio { get; set; }

        public decimal uvcost { get; set; }

        public decimal itemAmount { get; set; }

        public long CateId { get; set; }

        public DateTime CreateTime { get; set; }

        public long ShopId { get; set; }

        public int SellerType { get; set; }
    }
}
