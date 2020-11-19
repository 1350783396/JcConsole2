namespace Dal.CM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ApiSkus
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ApiSkus()
        {
            ApiItemSkuCostRanges = new HashSet<ApiItemSkuCostRanges>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long sku_id { get; set; }

        public long num_iid { get; set; }

        [StringLength(256)]
        public string properties { get; set; }

        [StringLength(256)]
        public string properties_name { get; set; }

        public DateTime created { get; set; }

        public DateTime modified { get; set; }

        [StringLength(64)]
        public string outer_id { get; set; }

        public decimal price { get; set; }

        public long quantity { get; set; }

        public decimal cost { get; set; }

        public virtual ApiItem ApiItem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ApiItemSkuCostRanges> ApiItemSkuCostRanges { get; set; }
    }
}
