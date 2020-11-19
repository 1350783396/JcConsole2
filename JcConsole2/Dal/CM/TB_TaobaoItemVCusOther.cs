namespace Dal.CM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_TaobaoItemVCusOther
    {
        public int id { get; set; }

        public DateTime day { get; set; }

        [StringLength(32)]
        public string aid { get; set; }

        [StringLength(255)]
        public string pic { get; set; }

        [StringLength(255)]
        public string aname { get; set; }

        [StringLength(10)]
        public string srate { get; set; }

        [StringLength(10)]
        public string isb { get; set; }

        [StringLength(32)]
        public string sid { get; set; }

        [StringLength(255)]
        public string sname { get; set; }

        public decimal p { get; set; }

        public long ItemId { get; set; }

        public int ShopID { get; set; }

        public virtual TB_TaobaoShop TB_TaobaoShop { get; set; }
    }
}
