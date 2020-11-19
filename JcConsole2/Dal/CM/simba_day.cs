namespace Dal.CM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class simba_day
    {
        public int id { get; set; }

        public DateTime thedate { get; set; }

        public int impression { get; set; }

        public int impressionBg { get; set; }

        public int click { get; set; }

        public decimal cost { get; set; }

        public int successCount { get; set; }

        public decimal clickChangePecent { get; set; }

        public decimal totalMoney { get; set; }

        public int favitemtotal { get; set; }

        public int shopcatCount { get; set; }

        public int showPM { get; set; }

        public decimal directtransaction { get; set; }

        public int successCountDirect { get; set; }

        public int successCountIn { get; set; }

        public int favshoptotal { get; set; }

        public decimal indirecttransaction { get; set; }

        public int indirectcarttotal { get; set; }

        public int directcarttotal { get; set; }

        public int favtotal { get; set; }

        public decimal freeBuyMoney { get; set; }

        public DateTime updateDate { get; set; }

        public long itemId { get; set; }

        public int ShopID { get; set; }

        public virtual TB_TaobaoShop TB_TaobaoShop { get; set; }
    }
}
