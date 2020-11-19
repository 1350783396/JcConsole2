namespace Dal.CM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_TaobaoShop
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TB_TaobaoShop()
        {
            ApiAccount = new HashSet<ApiAccount>();
            ApiDeliveryTemplateR = new HashSet<ApiDeliveryTemplateR>();
            ApiItem = new HashSet<ApiItem>();
            ApiItemChange = new HashSet<ApiItemChange>();
            ApiRefund = new HashSet<ApiRefund>();
            ApiSellerCats = new HashSet<ApiSellerCats>();
            ApiTradeFlags = new HashSet<ApiTradeFlags>();
            ApiTrades2 = new HashSet<ApiTrades2>();
            FactItem = new HashSet<FactItem>();
            FactItemFrom = new HashSet<FactItemFrom>();
            FactItemFromHistory = new HashSet<FactItemFromHistory>();
            FactItemHistory = new HashSet<FactItemHistory>();
            FactVistor = new HashSet<FactVistor>();
            ItemIndustryWordsHistory = new HashSet<ItemIndustryWordsHistory>();
            ItemZtcDateInfo = new HashSet<ItemZtcDateInfo>();
            ItemZtcInfoDetail = new HashSet<ItemZtcInfoDetail>();
            ItemZtcInputInfo = new HashSet<ItemZtcInputInfo>();
            JZData = new HashSet<JZData>();
            JZItem = new HashSet<JZItem>();
            JZLostData = new HashSet<JZLostData>();
            JZLostDetail = new HashSet<JZLostDetail>();
            LL_LiuLiangFromDetail = new HashSet<LL_LiuLiangFromDetail>();
            LL_LiuLiangFromMobile = new HashSet<LL_LiuLiangFromMobile>();
            LL_LiuLiangPc = new HashSet<LL_LiuLiangPc>();
            simba_day = new HashSet<simba_day>();
            TaskInfoes = new HashSet<TaskInfoes>();
            TaskKinds = new HashSet<TaskKinds>();
            TB_TaobaoAllCartCollect = new HashSet<TB_TaobaoAllCartCollect>();
            TB_TaobaoAllFromMobile = new HashSet<TB_TaobaoAllFromMobile>();
            TB_TaobaoAllFromPc = new HashSet<TB_TaobaoAllFromPc>();
            TB_TaobaoAllHome = new HashSet<TB_TaobaoAllHome>();
            TB_TaobaoAllPenFen = new HashSet<TB_TaobaoAllPenFen>();
            TB_TaobaoAllTopMobile = new HashSet<TB_TaobaoAllTopMobile>();
            TB_TaobaoAllTopPc = new HashSet<TB_TaobaoAllTopPc>();
            TB_TaobaoAllWW = new HashSet<TB_TaobaoAllWW>();
            TB_TaobaoAllZx = new HashSet<TB_TaobaoAllZx>();
            TB_TaobaoDayInfo = new HashSet<TB_TaobaoDayInfo>();
            TB_TaobaoDaySellInfo = new HashSet<TB_TaobaoDaySellInfo>();
            TB_TaobaoDaySellInfoMobile = new HashSet<TB_TaobaoDaySellInfoMobile>();
            TB_TaobaoDDS = new HashSet<TB_TaobaoDDS>();
            TB_TaobaoItem = new HashSet<TB_TaobaoItem>();
            TB_TaobaoItemAd = new HashSet<TB_TaobaoItemAd>();
            TB_TaobaoItemAim = new HashSet<TB_TaobaoItemAim>();
            TB_TaobaoItemDiamondShow = new HashSet<TB_TaobaoItemDiamondShow>();
            TB_TaobaoItemExt = new HashSet<TB_TaobaoItemExt>();
            TB_TaobaoItemInfoMobile = new HashSet<TB_TaobaoItemInfoMobile>();
            TB_TaobaoItemMarketing = new HashSet<TB_TaobaoItemMarketing>();
            TB_TaobaoItemPicModify = new HashSet<TB_TaobaoItemPicModify>();
            TB_TaobaoItemSeo = new HashSet<TB_TaobaoItemSeo>();
            TB_TaobaoItemStrategy = new HashSet<TB_TaobaoItemStrategy>();
            TB_TaobaoItemTag = new HashSet<TB_TaobaoItemTag>();
            TB_TaobaoItemTagType = new HashSet<TB_TaobaoItemTagType>();
            TB_TaobaoItemVCus = new HashSet<TB_TaobaoItemVCus>();
            TB_TaobaoItemVCusOther = new HashSet<TB_TaobaoItemVCusOther>();
            TB_TaobaoItemWeekPlan = new HashSet<TB_TaobaoItemWeekPlan>();
            TB_TaobaoLzDayInfo = new HashSet<TB_TaobaoLzDayInfo>();
            TB_TaobaoLzDayInfoMobile = new HashSet<TB_TaobaoLzDayInfoMobile>();
            YSF_shop_wireless_platform_src_new_d = new HashSet<YSF_shop_wireless_platform_src_new_d>();
            TB_TaobaoShua = new HashSet<TB_TaobaoShua>();
            TB_TaobaoShuaAll = new HashSet<TB_TaobaoShuaAll>();
            TB_TaobaoSimba3Days = new HashSet<TB_TaobaoSimba3Days>();
            TB_TaobaoSimbaFull = new HashSet<TB_TaobaoSimbaFull>();
            TB_TaobaoSimbaToday = new HashSet<TB_TaobaoSimbaToday>();
            YSF_auction_app_query_effect_new_d = new HashSet<YSF_auction_app_query_effect_new_d>();
            YSF_auction_comment_d = new HashSet<YSF_auction_comment_d>();
            YSF_auction_pc_search_src_effect_new_d = new HashSet<YSF_auction_pc_search_src_effect_new_d>();
            YSF_auction_pc_src_effect_d = new HashSet<YSF_auction_pc_src_effect_d>();
            YSF_auction_platform_trade_d = new HashSet<YSF_auction_platform_trade_d>();
            YSF_auction_query_effect_d = new HashSet<YSF_auction_query_effect_d>();
            YSF_auction_trade_src_d = new HashSet<YSF_auction_trade_src_d>();
            YSF_item_3 = new HashSet<YSF_item_3>();
            YSF_item_app_src_platform_new_d = new HashSet<YSF_item_app_src_platform_new_d>();
            YSF_item_search_effect_new_d = new HashSet<YSF_item_search_effect_new_d>();
            YSF_item_source_last_effect_new_d = new HashSet<YSF_item_source_last_effect_new_d>();
            YSF_pc_search_src_effect_d = new HashSet<YSF_pc_search_src_effect_d>();
            YSF_platform_source_traffic_d = new HashSet<YSF_platform_source_traffic_d>();
            YSF_shop_1 = new HashSet<YSF_shop_1>();
            YSF_shop_2 = new HashSet<YSF_shop_2>();
            YSF_shop_src_last_effect_d = new HashSet<YSF_shop_src_last_effect_d>();
            YSF_new_shop_weblog_d = new HashSet<YSF_new_shop_weblog_d>();
            YSF_new_shop_wireless_log_d_all = new HashSet<YSF_new_shop_wireless_log_d_all>();
            YSF_sku_trade_d = new HashSet<YSF_sku_trade_d>();
            TB_ZTCTool = new HashSet<TB_ZTCTool>();
            ZWShopPlan = new HashSet<ZWShopPlan>();
        }

        public int id { get; set; }

        [StringLength(64)]
        public string ShopID { get; set; }

        [Required]
        [StringLength(255)]
        public string ShopName { get; set; }

        public int ShopType { get; set; }

        [Required]
        [StringLength(255)]
        public string Url { get; set; }

        public decimal? fee { get; set; }

        public DateTime? CreateDate { get; set; }

        public decimal SWorkMoney { get; set; }

        public decimal SExpreeMoney { get; set; }

        public short? AutoPFlag { get; set; }

        [StringLength(800)]
        public string AccessToken { get; set; }

        public DateTime? AccessEnd { get; set; }

        public DateTime? LastTradeModifyDate { get; set; }

        public DateTime? LastRefundDate { get; set; }

        [StringLength(128)]
        public string UserID { get; set; }

        public int? get_order { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ApiAccount> ApiAccount { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ApiDeliveryTemplateR> ApiDeliveryTemplateR { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ApiItem> ApiItem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ApiItemChange> ApiItemChange { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ApiRefund> ApiRefund { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ApiSellerCats> ApiSellerCats { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ApiTradeFlags> ApiTradeFlags { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ApiTrades2> ApiTrades2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FactItem> FactItem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FactItemFrom> FactItemFrom { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FactItemFromHistory> FactItemFromHistory { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FactItemHistory> FactItemHistory { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FactVistor> FactVistor { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ItemIndustryWordsHistory> ItemIndustryWordsHistory { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ItemZtcDateInfo> ItemZtcDateInfo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ItemZtcInfoDetail> ItemZtcInfoDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ItemZtcInputInfo> ItemZtcInputInfo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<JZData> JZData { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<JZItem> JZItem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<JZLostData> JZLostData { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<JZLostDetail> JZLostDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LL_LiuLiangFromDetail> LL_LiuLiangFromDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LL_LiuLiangFromMobile> LL_LiuLiangFromMobile { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LL_LiuLiangPc> LL_LiuLiangPc { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<simba_day> simba_day { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TaskInfoes> TaskInfoes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TaskKinds> TaskKinds { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_TaobaoAllCartCollect> TB_TaobaoAllCartCollect { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_TaobaoAllFromMobile> TB_TaobaoAllFromMobile { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_TaobaoAllFromPc> TB_TaobaoAllFromPc { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_TaobaoAllHome> TB_TaobaoAllHome { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_TaobaoAllPenFen> TB_TaobaoAllPenFen { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_TaobaoAllTopMobile> TB_TaobaoAllTopMobile { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_TaobaoAllTopPc> TB_TaobaoAllTopPc { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_TaobaoAllWW> TB_TaobaoAllWW { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_TaobaoAllZx> TB_TaobaoAllZx { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_TaobaoDayInfo> TB_TaobaoDayInfo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_TaobaoDaySellInfo> TB_TaobaoDaySellInfo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_TaobaoDaySellInfoMobile> TB_TaobaoDaySellInfoMobile { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_TaobaoDDS> TB_TaobaoDDS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_TaobaoItem> TB_TaobaoItem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_TaobaoItemAd> TB_TaobaoItemAd { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_TaobaoItemAim> TB_TaobaoItemAim { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_TaobaoItemDiamondShow> TB_TaobaoItemDiamondShow { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_TaobaoItemExt> TB_TaobaoItemExt { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_TaobaoItemInfoMobile> TB_TaobaoItemInfoMobile { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_TaobaoItemMarketing> TB_TaobaoItemMarketing { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_TaobaoItemPicModify> TB_TaobaoItemPicModify { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_TaobaoItemSeo> TB_TaobaoItemSeo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_TaobaoItemStrategy> TB_TaobaoItemStrategy { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_TaobaoItemTag> TB_TaobaoItemTag { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_TaobaoItemTagType> TB_TaobaoItemTagType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_TaobaoItemVCus> TB_TaobaoItemVCus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_TaobaoItemVCusOther> TB_TaobaoItemVCusOther { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_TaobaoItemWeekPlan> TB_TaobaoItemWeekPlan { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_TaobaoLzDayInfo> TB_TaobaoLzDayInfo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_TaobaoLzDayInfoMobile> TB_TaobaoLzDayInfoMobile { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<YSF_shop_wireless_platform_src_new_d> YSF_shop_wireless_platform_src_new_d { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_TaobaoShua> TB_TaobaoShua { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_TaobaoShuaAll> TB_TaobaoShuaAll { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_TaobaoSimba3Days> TB_TaobaoSimba3Days { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_TaobaoSimbaFull> TB_TaobaoSimbaFull { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_TaobaoSimbaToday> TB_TaobaoSimbaToday { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<YSF_auction_app_query_effect_new_d> YSF_auction_app_query_effect_new_d { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<YSF_auction_comment_d> YSF_auction_comment_d { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<YSF_auction_pc_search_src_effect_new_d> YSF_auction_pc_search_src_effect_new_d { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<YSF_auction_pc_src_effect_d> YSF_auction_pc_src_effect_d { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<YSF_auction_platform_trade_d> YSF_auction_platform_trade_d { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<YSF_auction_query_effect_d> YSF_auction_query_effect_d { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<YSF_auction_trade_src_d> YSF_auction_trade_src_d { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<YSF_item_3> YSF_item_3 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<YSF_item_app_src_platform_new_d> YSF_item_app_src_platform_new_d { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<YSF_item_search_effect_new_d> YSF_item_search_effect_new_d { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<YSF_item_source_last_effect_new_d> YSF_item_source_last_effect_new_d { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<YSF_pc_search_src_effect_d> YSF_pc_search_src_effect_d { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<YSF_platform_source_traffic_d> YSF_platform_source_traffic_d { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<YSF_shop_1> YSF_shop_1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<YSF_shop_2> YSF_shop_2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<YSF_shop_src_last_effect_d> YSF_shop_src_last_effect_d { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<YSF_new_shop_weblog_d> YSF_new_shop_weblog_d { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<YSF_new_shop_wireless_log_d_all> YSF_new_shop_wireless_log_d_all { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<YSF_sku_trade_d> YSF_sku_trade_d { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_ZTCTool> TB_ZTCTool { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ZWShopPlan> ZWShopPlan { get; set; }
    }
}
