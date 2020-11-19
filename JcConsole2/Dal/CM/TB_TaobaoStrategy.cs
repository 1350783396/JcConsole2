namespace Dal.CM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_TaobaoStrategy
    {
        public int id { get; set; }

        public int AimID { get; set; }

        public int Year { get; set; }

        public int? Month { get; set; }

        public int? Week { get; set; }

        public byte DataType { get; set; }

        [StringLength(800)]
        public string Stratety { get; set; }

        public DateTime CreateDate { get; set; }

        [StringLength(128)]
        public string CreateID { get; set; }

        [StringLength(800)]
        public string Summery { get; set; }

        public DateTime? FinishDate { get; set; }

        public int ShopID { get; set; }

        public virtual TB_TaobaoAim TB_TaobaoAim { get; set; }
    }
}
