namespace Dal.CM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ApiDeliveryTemplateR")]
    public partial class ApiDeliveryTemplateR
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ApiDeliveryTemplateR()
        {
            ApiTopFeeRs = new HashSet<ApiTopFeeRs>();
        }

        [Key]
        public long template_id { get; set; }

        [Required]
        [StringLength(60)]
        public string name { get; set; }

        [Required]
        [StringLength(60)]
        public string ExpressCompany { get; set; }

        public int valuation { get; set; }

        public DateTime created { get; set; }

        public decimal start_standard { get; set; }

        public decimal start_fee { get; set; }

        public decimal add_standard { get; set; }

        public decimal add_fee { get; set; }

        public int ShopID { get; set; }

        public virtual TB_TaobaoShop TB_TaobaoShop { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ApiTopFeeRs> ApiTopFeeRs { get; set; }
    }
}
