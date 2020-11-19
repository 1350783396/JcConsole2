namespace Dal.CM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ApiItemCatsIndustryInfo")]
    public partial class ApiItemCatsIndustryInfo
    {
        public int id { get; set; }

        public DateTime thedate { get; set; }

        public long catId { get; set; }

        public int? index { get; set; }

        [StringLength(64)]
        public string keyword { get; set; }

        public int? searchPv { get; set; }

        public decimal? shopClickP { get; set; }

        public decimal? clickP { get; set; }

        public int? clickHot { get; set; }

        public decimal? payP { get; set; }

        public decimal? p3p { get; set; }

        public int? ShopID { get; set; }

        [StringLength(20)]
        public string type { get; set; }

        public decimal? sousuorenshu { get; set; }

        public decimal? dianjirenshu { get; set; }

        public decimal? zhifumaijiashu { get; set; }

        [StringLength(50)]
        public string CreateUser { get; set; }
    }
}
