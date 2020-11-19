namespace Dal.CM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TaskInfoes
    {
        public int id { get; set; }

        public long? ItemId { get; set; }

        public int KindId { get; set; }

        [StringLength(64)]
        public string Kind { get; set; }

        [Required]
        [StringLength(255)]
        public string Title { get; set; }

        [StringLength(64)]
        public string Owner { get; set; }

        public string Content { get; set; }

        [StringLength(32)]
        public string Color { get; set; }

        public DateTime Start { get; set; }

        public DateTime End { get; set; }

        public short Type { get; set; }

        public decimal KPI { get; set; }

        public decimal KPIFinish { get; set; }

        public bool IsFinish { get; set; }

        [StringLength(800)]
        public string FinishRemark { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime? FinishDate { get; set; }

        public int ShopID { get; set; }

        public int? TypeID { get; set; }

        public virtual TB_TaobaoShop TB_TaobaoShop { get; set; }
    }
}
