namespace Dal.CM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ItemIndustryInfo")]
    public partial class ItemIndustryInfo
    {
        public int id { get; set; }

        [StringLength(64)]
        public string keyword { get; set; }

        public int searchPv { get; set; }

        public decimal searchPvPercent { get; set; }

        public int searchHot { get; set; }

        public decimal clickPercent { get; set; }

        public decimal shopClickPercent { get; set; }

        public int onlineGoodsCount { get; set; }

        public decimal p3p { get; set; }

        public int clickPop { get; set; }

        public int clickHot { get; set; }

        public int tradeIndex { get; set; }

        public decimal payPercent { get; set; }

        public decimal addPercent { get; set; }

        public decimal hightQuality { get; set; }

        public decimal searchDemansion { get; set; }

        public decimal clickDemansion { get; set; }

        public decimal hotDemansion { get; set; }

        [StringLength(64)]
        public string terminal { get; set; }

        public int days { get; set; }

        public decimal goldValue { get; set; }

        public DateTime updateDate { get; set; }

        public long itemId { get; set; }

        public int ShopID { get; set; }

        public int? ishide { get; set; }

        public int? impressionIndex { get; set; }

        public decimal? impressionRatio { get; set; }

        public decimal? ctr { get; set; }

        public int? clickIndex { get; set; }

        public decimal? avgPrice { get; set; }

        public decimal? cvr { get; set; }

        public int? competition { get; set; }

        public int? PimpressionIndex { get; set; }

        public decimal? PimpressionRatio { get; set; }

        public decimal? Pctr { get; set; }

        public int? PclickIndex { get; set; }

        public decimal? PavgPrice { get; set; }

        public decimal? Pcvr { get; set; }

        public int? Pcompetition { get; set; }

        public decimal? BlueSea { get; set; }

        public int? seManNum { get; set; }

        public int? SeClick { get; set; }

        public decimal? unitPrice { get; set; }

        public int? payMenNum { get; set; }

        public decimal? dealAmt { get; set; }

        [StringLength(100)]
        public string Optimalcategory { get; set; }

        public int? cateId { get; set; }
    }
}
