namespace Dal.CM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_TaobaoSimbaFull
    {
        public int id { get; set; }

        public int finprice { get; set; }

        public int alipay_num { get; set; }

        public decimal roc { get; set; }

        public int coll_num { get; set; }

        public decimal efficiency { get; set; }

        public int finclick { get; set; }

        public decimal avg_finprice { get; set; }

        public decimal alipay_amt { get; set; }

        public DateTime day { get; set; }

        public int ShopID { get; set; }

        public virtual TB_TaobaoShop TB_TaobaoShop { get; set; }
    }
}
