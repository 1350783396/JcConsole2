namespace Dal.CM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SYCM_BKSSNew
    {
        public int id { get; set; }

        public long? item { get; set; }

        public long? ShopId { get; set; }

        public DateTime? thedate { get; set; }

        public decimal? payRateIndex { get; set; }

        public decimal? cltHits { get; set; }

        public decimal? payItemCnt { get; set; }

        public decimal? seIpvUvHits { get; set; }

        public decimal? uvIndex { get; set; }

        public decimal? tradeIndex { get; set; }

        public decimal? cartHits { get; set; }
    }
}
