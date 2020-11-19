namespace Dal.CM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ApiTrades2
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ApiTrades2()
        {
            ApiOrders2 = new HashSet<ApiOrders2>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Tid { get; set; }

        [StringLength(64)]
        public string AlipayNo { get; set; }

        [StringLength(400)]
        public string BuyerMemo { get; set; }

        [StringLength(64)]
        public string BuyerNick { get; set; }

        public decimal CommissionFee { get; set; }

        public DateTime? ConsignTime { get; set; }

        public DateTime Created { get; set; }

        public decimal CreditCardFee { get; set; }

        public decimal DiscountFee { get; set; }

        public DateTime? EndTime { get; set; }

        public DateTime Modified { get; set; }

        public DateTime? PayTime { get; set; }

        public decimal Payment { get; set; }

        public decimal post_fee { get; set; }

        public decimal ReceivedPayment { get; set; }

        [StringLength(255)]
        public string ReceiverAddress { get; set; }

        [StringLength(64)]
        public string ReceiverCity { get; set; }

        [StringLength(64)]
        public string ReceiverDistrict { get; set; }

        [StringLength(64)]
        public string ReceiverMobile { get; set; }

        [StringLength(64)]
        public string ReceiverName { get; set; }

        [StringLength(64)]
        public string ReceiverPhone { get; set; }

        [StringLength(64)]
        public string ReceiverState { get; set; }

        [StringLength(64)]
        public string ReceiverZip { get; set; }

        public short SellerFlag { get; set; }

        public string SellerMemo { get; set; }

        [StringLength(64)]
        public string Status { get; set; }

        public decimal TotalFee { get; set; }

        public int src_id { get; set; }

        public decimal? AllFee { get; set; }

        public decimal? AllCost { get; set; }

        public DateTime? LastAllFeeDate { get; set; }

        public DateTime? LastAllCostDate { get; set; }

        public string ExpressInfo { get; set; }

        public bool IsShua { get; set; }

        public int ShopID { get; set; }

        [StringLength(64)]
        public string TradeFrom { get; set; }

        public int Platform { get; set; }

        [StringLength(64)]
        public string ShuaKeyWords { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ApiOrders2> ApiOrders2 { get; set; }

        public virtual TB_TaobaoShop TB_TaobaoShop { get; set; }
    }
}
