namespace Dal.CM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("JZData")]
    public partial class JZData
    {
        public int id { get; set; }

        public DateTime date { get; set; }

        public long item { get; set; }

        public int sellerCount { get; set; }

        [Required]
        public string qudao { get; set; }

        public string yingliu { get; set; }

        public string chenjiao { get; set; }

        public DateTime? CreateDate { get; set; }

        public int ShopID { get; set; }

        public long jzId { get; set; }

        public string qudaoJson { get; set; }

        public string yingliuJson { get; set; }

        public string chenjiaoJson { get; set; }

        public long jzItem { get; set; }

        public string detail { get; set; }

        public string detailJson { get; set; }

        public virtual TB_TaobaoShop TB_TaobaoShop { get; set; }
    }
}
