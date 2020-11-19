namespace Dal.CM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_TaobaoAllPenFen
    {
        public int id { get; set; }

        public int ShopID { get; set; }

        public int YearWeek { get; set; }

        public DateTime day { get; set; }

        public decimal DescFen { get; set; }

        public decimal ServiceFen { get; set; }

        public decimal SendFen { get; set; }

        public int SendHour { get; set; }

        public DateTime CreateDate { get; set; }

        public virtual TB_TaobaoShop TB_TaobaoShop { get; set; }
    }
}
