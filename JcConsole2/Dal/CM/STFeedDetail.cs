namespace Dal.CM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("STFeedDetail")]
    public partial class STFeedDetail
    {
        public int id { get; set; }

        public long ItemId { get; set; }

        public DateTime thedate { get; set; }

        public int guideInPv { get; set; }

        public int itmExpPv { get; set; }

        public int guideInUv { get; set; }

        public int guideInNewUv { get; set; }

        public int guideInPotUv { get; set; }

        public int guideInOldUv { get; set; }

        public decimal? clickRate { get; set; }

        public int? shopId { get; set; }
    }
}
