namespace Dal.CM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_TaobaoDayInfo
    {
        public int id { get; set; }

        public int ShopID { get; set; }

        public DateTime Date { get; set; }

        public int ViewCount { get; set; }

        public int CustomerCount { get; set; }

        public int ReCustomerCount { get; set; }

        public int AverageDeepCount { get; set; }

        public int SuccessCount { get; set; }

        public int AveragePrice { get; set; }

        public int SuccessReCount { get; set; }

        public decimal AliPayMoney { get; set; }

        public decimal BuyMoney { get; set; }

        public decimal PayMoney { get; set; }

        public decimal PayPerent { get; set; }

        public decimal GoPerent { get; set; }

        public decimal VirtualMoney { get; set; }

        [StringLength(128)]
        public string UserID { get; set; }

        public DateTime CreateDate { get; set; }

        public virtual TB_TaobaoShop TB_TaobaoShop { get; set; }
    }
}
