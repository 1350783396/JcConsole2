namespace Dal.CM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ApiAccount")]
    public partial class ApiAccount
    {
        public long id { get; set; }

        public long? Tid { get; set; }

        public int AccountType { get; set; }

        [StringLength(255)]
        public string title { get; set; }

        public bool isOut { get; set; }

        public decimal fee { get; set; }

        public int from { get; set; }

        [StringLength(255)]
        public string note { get; set; }

        public DateTime created { get; set; }

        public int ShopID { get; set; }

        public virtual TB_TaobaoShop TB_TaobaoShop { get; set; }
    }
}
