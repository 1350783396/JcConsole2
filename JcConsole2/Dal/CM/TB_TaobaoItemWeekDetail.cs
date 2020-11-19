namespace Dal.CM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_TaobaoItemWeekDetail
    {
        public int id { get; set; }

        [Required]
        [StringLength(500)]
        public string DetailName { get; set; }

        public int? TrgetNum { get; set; }

        public long? FactNum { get; set; }

        [StringLength(1000)]
        public string TragetStrategy { get; set; }

        [StringLength(1000)]
        public string dayNums { get; set; }

        public int? PlanID { get; set; }

        public string summary { get; set; }

        public int? ShopID { get; set; }

        public long? ItemID { get; set; }

        public int? parentID { get; set; }
    }
}
