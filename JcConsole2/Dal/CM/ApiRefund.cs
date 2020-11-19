namespace Dal.CM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ApiRefund")]
    public partial class ApiRefund
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long refund_id { get; set; }

        public long tid { get; set; }

        public long oid { get; set; }

        public decimal total_fee { get; set; }

        [StringLength(64)]
        public string buyer_nick { get; set; }

        [StringLength(64)]
        public string status { get; set; }

        public DateTime created { get; set; }

        public DateTime? modified { get; set; }

        public decimal refund_fee { get; set; }

        [StringLength(64)]
        public string good_status { get; set; }

        public bool has_good_return { get; set; }

        public decimal payment { get; set; }

        [StringLength(255)]
        public string reason { get; set; }

        [StringLength(800)]
        public string desc { get; set; }

        [StringLength(255)]
        public string title { get; set; }

        [StringLength(64)]
        public string company_name { get; set; }

        [StringLength(64)]
        public string sid { get; set; }

        public int ShopID { get; set; }

        public virtual TB_TaobaoShop TB_TaobaoShop { get; set; }
    }
}
