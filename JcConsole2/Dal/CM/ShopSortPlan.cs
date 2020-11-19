namespace Dal.CM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ShopSortPlan")]
    public partial class ShopSortPlan
    {
        public int id { get; set; }

        [StringLength(300)]
        public string map { get; set; }

        public long? shopid { get; set; }

        public DateTime? thedate { get; set; }

        public int? typeId { get; set; }

        [StringLength(50)]
        public string title { get; set; }

        [StringLength(300)]
        public string remark { get; set; }

        public decimal? articlePrice { get; set; }

        public long? itemId { get; set; }

        public int? isRelevance { get; set; }

        [StringLength(2000)]
        public string colour { get; set; }

        public int? year { get; set; }

        [StringLength(500)]
        public string january { get; set; }

        [StringLength(500)]
        public string february { get; set; }

        [StringLength(500)]
        public string march { get; set; }

        [StringLength(500)]
        public string april { get; set; }

        [StringLength(500)]
        public string may { get; set; }

        [StringLength(500)]
        public string june { get; set; }

        [StringLength(500)]
        public string july { get; set; }

        [StringLength(500)]
        public string august { get; set; }

        [StringLength(500)]
        public string september { get; set; }

        [StringLength(500)]
        public string octorber { get; set; }

        [StringLength(500)]
        public string november { get; set; }

        [StringLength(500)]
        public string december { get; set; }

        public int? type { get; set; }

        [StringLength(800)]
        public string lable { get; set; }

        [StringLength(800)]
        public string mainWord { get; set; }

        [StringLength(800)]
        public string crowd { get; set; }
    }
}
