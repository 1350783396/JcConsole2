namespace Dal.CM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_TaobaoAim
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TB_TaobaoAim()
        {
            TB_TaobaoStrategy = new HashSet<TB_TaobaoStrategy>();
        }

        public int id { get; set; }

        public int ShopID { get; set; }

        public int Year { get; set; }

        public int? Month { get; set; }

        public int? Week { get; set; }

        public int TotalDays { get; set; }

        public DateTime startDate { get; set; }

        public byte DataType { get; set; }

        public decimal? SalesRevenue { get; set; }

        public decimal? FactRevenue { get; set; }

        public decimal? Profit { get; set; }

        [StringLength(800)]
        public string AimWay { get; set; }

        [StringLength(800)]
        public string AimSummer { get; set; }

        public decimal? FinishPercent { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime? UpdateDate { get; set; }

        [Required]
        [StringLength(128)]
        public string CreateID { get; set; }

        [StringLength(128)]
        public string UpdateID { get; set; }

        public decimal? GoalConversion { get; set; }

        public decimal? ClientPrice { get; set; }

        public decimal? PromotionCost { get; set; }

        [StringLength(800)]
        public string Remark { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_TaobaoStrategy> TB_TaobaoStrategy { get; set; }
    }
}
