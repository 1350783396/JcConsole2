namespace Dal.CM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ApiItem")]
    public partial class ApiItem
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ApiItem()
        {
            ApiItemCostRanges = new HashSet<ApiItemCostRanges>();
            ApiItemSkuCostRanges = new HashSet<ApiItemSkuCostRanges>();
            ApiSkus = new HashSet<ApiSkus>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long num_iid { get; set; }

        [Required]
        [StringLength(128)]
        public string title { get; set; }

        [StringLength(128)]
        public string outer_id { get; set; }

        [StringLength(256)]
        public string pic_url { get; set; }

        public DateTime modified { get; set; }

        public decimal price { get; set; }

        public decimal cost { get; set; }

        public long postage_id { get; set; }

        [StringLength(800)]
        public string seller_cids { get; set; }

        public decimal item_weight { get; set; }

        public decimal item_size { get; set; }

        public int costType { get; set; }

        [StringLength(32)]
        public string approve_status { get; set; }

        public int ShopID { get; set; }

        [StringLength(32)]
        public string delist_time { get; set; }

        [StringLength(32)]
        public string list_time { get; set; }

        [StringLength(2000)]
        public string input_pids { get; set; }

        [StringLength(2000)]
        public string input_str { get; set; }

        public long cid { get; set; }

        public DateTime? created { get; set; }

        public virtual TB_TaobaoShop TB_TaobaoShop { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ApiItemCostRanges> ApiItemCostRanges { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ApiItemSkuCostRanges> ApiItemSkuCostRanges { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ApiSkus> ApiSkus { get; set; }
    }
}
