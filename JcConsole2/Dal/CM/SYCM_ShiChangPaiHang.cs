namespace Dal.CM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SYCM_ShiChangPaiHang
    {
        public int id { get; set; }

        public DateTime? thedate { get; set; }

        public long? cateId { get; set; }

        public long? itemId { get; set; }

        public string pictUrl { get; set; }

        public string detailUrl { get; set; }

        public bool? isMonitored { get; set; }

        public string title { get; set; }

        public long? shop_userId { get; set; }

        public string shop_pictureUrl { get; set; }

        public string shop_title { get; set; }

        public string shopUrl { get; set; }

        public decimal? seIpvUvHits { get; set; }

        public decimal uvIndex { get; set; }

        public int? cateRankId_cycleCqc { get; set; }

        public int? cateRankId_value { get; set; }

        public decimal? tradeIndex { get; set; }

        public decimal? zongfangke { get; set; }

        public int? sousuorenshu { get; set; }

        public decimal? amount { get; set; }

        public decimal? sousuoRate { get; set; }

        public decimal? uvjiazhi { get; set; }

        public string CreateUser { get; set; }

    }
}
