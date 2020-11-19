namespace Dal.CM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SuRecommend")]
    public partial class SuRecommend
    {
        public int id { get; set; }

        public int shopid { get; set; }

        public DateTime thedate { get; set; }

        public long materialId { get; set; }

        [Required]
        [StringLength(100)]
        public string campaignName { get; set; }

        [Required]
        [StringLength(100)]
        public string adgroupName { get; set; }

        public int adPv { get; set; }

        public int click { get; set; }

        public decimal ecpm { get; set; }

        public decimal charge { get; set; }

        public decimal ecpc { get; set; }

        public int prepayInshopNum { get; set; }

        public decimal prepayInshopAmt { get; set; }

        public decimal ctr { get; set; }

        public int inshopPv { get; set; }

        public decimal inshopPvRate { get; set; }

        public int inshopLandUv { get; set; }

        public int inshopNewUv { get; set; }

        public decimal inshopNewUvRate { get; set; }

        public int deepInshopUv { get; set; }

        public decimal avgAccessTime { get; set; }

        public decimal avgAccessPageNum { get; set; }

        public int dirShopColNum { get; set; }

        public int addNewUv { get; set; }

        public decimal addNewUvRate { get; set; }

        public decimal addNewUvCost { get; set; }

        public decimal newFCharge { get; set; }

        public int inshopItemColNum { get; set; }

        public int cartNum { get; set; }

        public int couponNum { get; set; }

        public int gmvInshopNum { get; set; }

        public decimal gmvInshopAmt { get; set; }

        public int alipayInShopNum { get; set; }

        public decimal alipayInshopAmt { get; set; }

        public decimal icvr { get; set; }

        public decimal cvr { get; set; }

        public decimal roi { get; set; }

        public long adgroupId { get; set; }

        [Required]
        [StringLength(200)]
        public string pic_url { get; set; }
    }
}
