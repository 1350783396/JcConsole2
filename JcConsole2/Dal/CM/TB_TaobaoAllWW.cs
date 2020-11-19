namespace Dal.CM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_TaobaoAllWW
    {
        public int id { get; set; }

        public int ShopID { get; set; }

        public DateTime day { get; set; }

        public int AskNum { get; set; }

        public decimal AskSuccessP { get; set; }

        public decimal AutoSuccessP { get; set; }

        public decimal ReturnMoney { get; set; }

        public int ReturnCount { get; set; }

        public DateTime CreateDate { get; set; }

        public virtual TB_TaobaoShop TB_TaobaoShop { get; set; }
    }
}
