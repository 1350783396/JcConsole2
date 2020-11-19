namespace Dal.CM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ApiOrders2
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Oid { get; set; }

        [StringLength(64)]
        public string InvoiceNo { get; set; }

        [StringLength(64)]
        public string LogisticsCompany { get; set; }

        public long Num { get; set; }

        public long NumIid { get; set; }

        [StringLength(64)]
        public string OuterIid { get; set; }

        public long refund_id { get; set; }

        public decimal Payment { get; set; }

        [StringLength(255)]
        public string PicPath { get; set; }

        public decimal Price { get; set; }

        [StringLength(64)]
        public string RefundStatus { get; set; }

        public long? SkuId { get; set; }

        [StringLength(400)]
        public string SkuPropertiesName { get; set; }

        [StringLength(64)]
        public string Status { get; set; }

        public string Title { get; set; }

        public decimal TotalFee { get; set; }

        public long Tid { get; set; }

        public virtual ApiTrades2 ApiTrades2 { get; set; }
    }
}
