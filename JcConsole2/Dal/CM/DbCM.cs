namespace Dal.CM
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DbCM : DbContext
    {
        public DbCM()
            : base("name=DbCM")
        {
        }

        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<ApiAccount> ApiAccount { get; set; }
        public virtual DbSet<ApiDeliveryTemplateR> ApiDeliveryTemplateR { get; set; }
        public virtual DbSet<ApiItem> ApiItem { get; set; }
        public virtual DbSet<ApiItemCats> ApiItemCats { get; set; }
        public virtual DbSet<ApiItemCatsIndustryInfo> ApiItemCatsIndustryInfo { get; set; }
        public virtual DbSet<ApiItemChange> ApiItemChange { get; set; }
        public virtual DbSet<ApiItemCostRanges> ApiItemCostRanges { get; set; }
        public virtual DbSet<ApiItemSkuCostRanges> ApiItemSkuCostRanges { get; set; }
        public virtual DbSet<ApiLogisticsCompany> ApiLogisticsCompany { get; set; }
        public virtual DbSet<ApiOrders2> ApiOrders2 { get; set; }
        public virtual DbSet<ApiRefund> ApiRefund { get; set; }
        public virtual DbSet<ApiSellerCats> ApiSellerCats { get; set; }
        public virtual DbSet<ApiSkus> ApiSkus { get; set; }
        public virtual DbSet<ApiTasks> ApiTasks { get; set; }
        public virtual DbSet<ApiTopFeeRs> ApiTopFeeRs { get; set; }
        public virtual DbSet<ApiTradeFlags> ApiTradeFlags { get; set; }
        public virtual DbSet<ApiTrades2> ApiTrades2 { get; set; }
        public virtual DbSet<CostBreakdown> CostBreakdown { get; set; }
        public virtual DbSet<CostData> CostData { get; set; }
        public virtual DbSet<EventTrace> EventTrace { get; set; }
        public virtual DbSet<FactItem> FactItem { get; set; }
        public virtual DbSet<FactItemFrom> FactItemFrom { get; set; }
        public virtual DbSet<FactItemFromHistory> FactItemFromHistory { get; set; }
        public virtual DbSet<FactItemHistory> FactItemHistory { get; set; }
        public virtual DbSet<FactVistor> FactVistor { get; set; }
        public virtual DbSet<HostItemConfig> HostItemConfig { get; set; }
        public virtual DbSet<ItemConfiguration> ItemConfiguration { get; set; }
        public virtual DbSet<ItemConversionRate> ItemConversionRate { get; set; }
        public virtual DbSet<ItemIndustryInfo> ItemIndustryInfo { get; set; }
        public virtual DbSet<ItemIndustryWordsHistory> ItemIndustryWordsHistory { get; set; }
        public virtual DbSet<ItemZtcDateInfo> ItemZtcDateInfo { get; set; }
        public virtual DbSet<ItemZtcInfoDetail> ItemZtcInfoDetail { get; set; }
        public virtual DbSet<ItemZtcInputInfo> ItemZtcInputInfo { get; set; }
        public virtual DbSet<JZData> JZData { get; set; }
        public virtual DbSet<JZItem> JZItem { get; set; }
        public virtual DbSet<JzItemChange> JzItemChange { get; set; }
        public virtual DbSet<JZLostData> JZLostData { get; set; }
        public virtual DbSet<JZLostDetail> JZLostDetail { get; set; }
        public virtual DbSet<KeyAnalysis_Exclude> KeyAnalysis_Exclude { get; set; }
        public virtual DbSet<LL_LiuLiangFromDetail> LL_LiuLiangFromDetail { get; set; }
        public virtual DbSet<LL_LiuLiangFromMobile> LL_LiuLiangFromMobile { get; set; }
        public virtual DbSet<LL_LiuLiangPc> LL_LiuLiangPc { get; set; }
        public virtual DbSet<NewItemPlan> NewItemPlan { get; set; }
        public virtual DbSet<Pdd_DayReport> Pdd_DayReport { get; set; }
        public virtual DbSet<PlanChannelConfig> PlanChannelConfig { get; set; }
        public virtual DbSet<PM_HISTORY> PM_HISTORY { get; set; }
        public virtual DbSet<ProductLanding> ProductLanding { get; set; }
        public virtual DbSet<ShopSort> ShopSort { get; set; }
        public virtual DbSet<ShopSortPlan> ShopSortPlan { get; set; }
        public virtual DbSet<simba_day> simba_day { get; set; }
        public virtual DbSet<SPShopConfig> SPShopConfig { get; set; }
        public virtual DbSet<STFeedDetail> STFeedDetail { get; set; }
        public virtual DbSet<SubWayClick> SubWayClick { get; set; }
        public virtual DbSet<SuPThesaurus> SuPThesaurus { get; set; }
        public virtual DbSet<SuRecommend> SuRecommend { get; set; }
        public virtual DbSet<SYCM_BKSSNew> SYCM_BKSSNew { get; set; }
        public virtual DbSet<SYCM_SCPHPinPai> SYCM_SCPHPinPai { get; set; }
        public virtual DbSet<SYCM_ShiChangDaPan> SYCM_ShiChangDaPan { get; set; }
        public virtual DbSet<SYCM_ShiChangPaiHang> SYCM_ShiChangPaiHang { get; set; }
        public virtual DbSet<SYCM_SSKeyword> SYCM_SSKeyword { get; set; }
        public virtual DbSet<SYCM_SSQuDao> SYCM_SSQuDao { get; set; }
        public virtual DbSet<TacticsWeekConfig> TacticsWeekConfig { get; set; }
        public virtual DbSet<TaskInfoes> TaskInfoes { get; set; }
        public virtual DbSet<TaskKinds> TaskKinds { get; set; }
        public virtual DbSet<TB_SCDPMonthdata> TB_SCDPMonthdata { get; set; }
        public virtual DbSet<TB_TaobaoAim> TB_TaobaoAim { get; set; }
        public virtual DbSet<TB_TaobaoAllCartCollect> TB_TaobaoAllCartCollect { get; set; }
        public virtual DbSet<TB_TaobaoAllFromMobile> TB_TaobaoAllFromMobile { get; set; }
        public virtual DbSet<TB_TaobaoAllFromPc> TB_TaobaoAllFromPc { get; set; }
        public virtual DbSet<TB_TaobaoAllHome> TB_TaobaoAllHome { get; set; }
        public virtual DbSet<TB_TaobaoAllPenFen> TB_TaobaoAllPenFen { get; set; }
        public virtual DbSet<TB_TaobaoAllTopMobile> TB_TaobaoAllTopMobile { get; set; }
        public virtual DbSet<TB_TaobaoAllTopPc> TB_TaobaoAllTopPc { get; set; }
        public virtual DbSet<TB_TaobaoAllWW> TB_TaobaoAllWW { get; set; }
        public virtual DbSet<TB_TaobaoAllZx> TB_TaobaoAllZx { get; set; }
        public virtual DbSet<TB_TaobaoCost> TB_TaobaoCost { get; set; }
        public virtual DbSet<TB_TaoBaoCustomizeCategory> TB_TaoBaoCustomizeCategory { get; set; }
        public virtual DbSet<TB_TaobaoDayInfo> TB_TaobaoDayInfo { get; set; }
        public virtual DbSet<TB_TaobaoDaySellInfo> TB_TaobaoDaySellInfo { get; set; }
        public virtual DbSet<TB_TaobaoDaySellInfoMobile> TB_TaobaoDaySellInfoMobile { get; set; }
        public virtual DbSet<TB_TaobaoDDS> TB_TaobaoDDS { get; set; }
        public virtual DbSet<TB_TaobaoItem> TB_TaobaoItem { get; set; }
        public virtual DbSet<TB_TaobaoItemAd> TB_TaobaoItemAd { get; set; }
        public virtual DbSet<TB_TaobaoItemAim> TB_TaobaoItemAim { get; set; }
        public virtual DbSet<TB_TaobaoItemDiamondShow> TB_TaobaoItemDiamondShow { get; set; }
        public virtual DbSet<TB_TaobaoItemExt> TB_TaobaoItemExt { get; set; }
        public virtual DbSet<TB_TaobaoItemInfoMobile> TB_TaobaoItemInfoMobile { get; set; }
        public virtual DbSet<TB_TaobaoItemMarketing> TB_TaobaoItemMarketing { get; set; }
        public virtual DbSet<TB_TaobaoItemPicModify> TB_TaobaoItemPicModify { get; set; }
        public virtual DbSet<TB_TaobaoItemSeo> TB_TaobaoItemSeo { get; set; }
        public virtual DbSet<TB_TaobaoItemStrategy> TB_TaobaoItemStrategy { get; set; }
        public virtual DbSet<TB_TaobaoItemTag> TB_TaobaoItemTag { get; set; }
        public virtual DbSet<TB_TaobaoItemTagType> TB_TaobaoItemTagType { get; set; }
        public virtual DbSet<TB_TaobaoItemVCus> TB_TaobaoItemVCus { get; set; }
        public virtual DbSet<TB_TaobaoItemVCusOther> TB_TaobaoItemVCusOther { get; set; }
        public virtual DbSet<TB_TaobaoItemWeekDetail> TB_TaobaoItemWeekDetail { get; set; }
        public virtual DbSet<TB_TaobaoItemWeekPlan> TB_TaobaoItemWeekPlan { get; set; }
        public virtual DbSet<TB_TaobaoItemWeekTask> TB_TaobaoItemWeekTask { get; set; }
        public virtual DbSet<TB_TaobaoLzDayInfo> TB_TaobaoLzDayInfo { get; set; }
        public virtual DbSet<TB_TaobaoLzDayInfoMobile> TB_TaobaoLzDayInfoMobile { get; set; }
        public virtual DbSet<TB_TaobaoMonthCost> TB_TaobaoMonthCost { get; set; }
        public virtual DbSet<TB_TaobaoShop> TB_TaobaoShop { get; set; }
        public virtual DbSet<TB_TaobaoShua> TB_TaobaoShua { get; set; }
        public virtual DbSet<TB_TaobaoShuaAll> TB_TaobaoShuaAll { get; set; }
        public virtual DbSet<TB_TaobaoSimba3Days> TB_TaobaoSimba3Days { get; set; }
        public virtual DbSet<TB_TaobaoSimbaFull> TB_TaobaoSimbaFull { get; set; }
        public virtual DbSet<TB_TaobaoSimbaToday> TB_TaobaoSimbaToday { get; set; }
        public virtual DbSet<TB_TaobaoStrategy> TB_TaobaoStrategy { get; set; }
        public virtual DbSet<TB_ZTCTool> TB_ZTCTool { get; set; }
        public virtual DbSet<TestModel1> TestModel1 { get; set; }
        public virtual DbSet<UserItemRole> UserItemRole { get; set; }
        public virtual DbSet<UserShopRole> UserShopRole { get; set; }
        public virtual DbSet<UserWebRole> UserWebRole { get; set; }
        public virtual DbSet<YSF_auction_app_query_effect_new_d> YSF_auction_app_query_effect_new_d { get; set; }
        public virtual DbSet<YSF_auction_comment_d> YSF_auction_comment_d { get; set; }
        public virtual DbSet<YSF_auction_pc_search_src_effect_new_d> YSF_auction_pc_search_src_effect_new_d { get; set; }
        public virtual DbSet<YSF_auction_pc_src_effect_d> YSF_auction_pc_src_effect_d { get; set; }
        public virtual DbSet<YSF_auction_platform_trade_d> YSF_auction_platform_trade_d { get; set; }
        public virtual DbSet<YSF_auction_query_effect_d> YSF_auction_query_effect_d { get; set; }
        public virtual DbSet<YSF_auction_trade_src_d> YSF_auction_trade_src_d { get; set; }
        public virtual DbSet<YSF_dim_pc_src_new_d> YSF_dim_pc_src_new_d { get; set; }
        public virtual DbSet<YSF_dim_wireless_src_new_d> YSF_dim_wireless_src_new_d { get; set; }
        public virtual DbSet<YSF_item_3> YSF_item_3 { get; set; }
        public virtual DbSet<YSF_item_app_src_platform_new_d> YSF_item_app_src_platform_new_d { get; set; }
        public virtual DbSet<YSF_item_search_effect_new_d> YSF_item_search_effect_new_d { get; set; }
        public virtual DbSet<YSF_item_source_last_effect_new_d> YSF_item_source_last_effect_new_d { get; set; }
        public virtual DbSet<YSF_new_shop_weblog_d> YSF_new_shop_weblog_d { get; set; }
        public virtual DbSet<YSF_new_shop_wireless_log_d_all> YSF_new_shop_wireless_log_d_all { get; set; }
        public virtual DbSet<YSF_pc_search_src_effect_d> YSF_pc_search_src_effect_d { get; set; }
        public virtual DbSet<YSF_platform_source_traffic_d> YSF_platform_source_traffic_d { get; set; }
        public virtual DbSet<YSF_shop_1> YSF_shop_1 { get; set; }
        public virtual DbSet<YSF_shop_2> YSF_shop_2 { get; set; }
        public virtual DbSet<YSF_shop_src_last_effect_d> YSF_shop_src_last_effect_d { get; set; }
        public virtual DbSet<YSF_shop_wireless_platform_src_new_d> YSF_shop_wireless_platform_src_new_d { get; set; }
        public virtual DbSet<YSF_sku_trade_d> YSF_sku_trade_d { get; set; }
        public virtual DbSet<YY_Type> YY_Type { get; set; }
        public virtual DbSet<ZWCateTagTypeInfo> ZWCateTagTypeInfo { get; set; }
        public virtual DbSet<ZWShopPlan> ZWShopPlan { get; set; }
        public virtual DbSet<JZData2> JZData2 { get; set; }
        public virtual DbSet<KeyWord_Marker1> KeyWord_Marker1 { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ApiItemCatsIndustryInfo>()
                .Property(e => e.shopClickP)
                .HasPrecision(20, 7);

            modelBuilder.Entity<ApiItemCatsIndustryInfo>()
                .Property(e => e.clickP)
                .HasPrecision(20, 7);

            modelBuilder.Entity<ApiItemCatsIndustryInfo>()
                .Property(e => e.payP)
                .HasPrecision(20, 7);

            modelBuilder.Entity<ApiItemCatsIndustryInfo>()
                .Property(e => e.p3p)
                .HasPrecision(20, 7);

            modelBuilder.Entity<ApiItemCatsIndustryInfo>()
                .Property(e => e.type)
                .IsUnicode(false);

            modelBuilder.Entity<ApiItemCatsIndustryInfo>()
                .Property(e => e.sousuorenshu)
                .HasPrecision(20, 7);

            modelBuilder.Entity<ApiItemCatsIndustryInfo>()
                .Property(e => e.dianjirenshu)
                .HasPrecision(20, 7);

            modelBuilder.Entity<ApiItemCatsIndustryInfo>()
                .Property(e => e.zhifumaijiashu)
                .HasPrecision(20, 7);

            modelBuilder.Entity<ApiSkus>()
                .HasMany(e => e.ApiItemSkuCostRanges)
                .WithRequired(e => e.ApiSkus)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HostItemConfig>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<HostItemConfig>()
                .Property(e => e.rate_arry)
                .IsUnicode(false);

            modelBuilder.Entity<HostItemConfig>()
                .Property(e => e.remark)
                .IsUnicode(false);

            modelBuilder.Entity<HostItemConfig>()
                .Property(e => e.warning)
                .IsUnicode(false);

            modelBuilder.Entity<ItemConversionRate>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<ItemConversionRate>()
                .Property(e => e.value)
                .IsFixedLength();

            modelBuilder.Entity<ItemConversionRate>()
                .Property(e => e.userId)
                .IsUnicode(false);

            modelBuilder.Entity<ItemIndustryInfo>()
                .Property(e => e.searchPvPercent)
                .HasPrecision(18, 4);

            modelBuilder.Entity<ItemIndustryInfo>()
                .Property(e => e.clickPercent)
                .HasPrecision(18, 4);

            modelBuilder.Entity<ItemIndustryInfo>()
                .Property(e => e.shopClickPercent)
                .HasPrecision(18, 4);

            modelBuilder.Entity<ItemIndustryInfo>()
                .Property(e => e.payPercent)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ItemIndustryInfo>()
                .Property(e => e.goldValue)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ItemIndustryInfo>()
                .Property(e => e.Optimalcategory)
                .IsUnicode(false);

            modelBuilder.Entity<ItemZtcInfoDetail>()
                .Property(e => e.pv_percent)
                .HasPrecision(10, 4);

            modelBuilder.Entity<ItemZtcInfoDetail>()
                .Property(e => e.order_percent)
                .HasPrecision(10, 4);

            modelBuilder.Entity<ItemZtcInfoDetail>()
                .Property(e => e.pay_percent)
                .HasPrecision(10, 4);

            modelBuilder.Entity<LL_LiuLiangFromMobile>()
                .Property(e => e.bounceRate)
                .HasPrecision(18, 4);

            modelBuilder.Entity<LL_LiuLiangFromMobile>()
                .Property(e => e.chainRoc)
                .HasPrecision(18, 4);

            modelBuilder.Entity<LL_LiuLiangPc>()
                .Property(e => e.bounceRate)
                .HasPrecision(18, 4);

            modelBuilder.Entity<LL_LiuLiangPc>()
                .Property(e => e.chainRoc)
                .HasPrecision(18, 4);

            modelBuilder.Entity<NewItemPlan>()
                .Property(e => e.mude_rate)
                .IsUnicode(false);

            modelBuilder.Entity<NewItemPlan>()
                .Property(e => e.remark)
                .IsUnicode(false);

            modelBuilder.Entity<NewItemPlan>()
                .Property(e => e.keyWord)
                .IsUnicode(false);

            modelBuilder.Entity<PM_HISTORY>()
                .Property(e => e.word)
                .IsUnicode(false);

            modelBuilder.Entity<PM_HISTORY>()
                .Property(e => e.wordhash)
                .IsUnicode(false);

            modelBuilder.Entity<SubWayClick>()
                .Property(e => e.clickid)
                .IsUnicode(false);

            modelBuilder.Entity<SubWayClick>()
                .Property(e => e.clickTimeStr)
                .IsUnicode(false);

            modelBuilder.Entity<SubWayClick>()
                .Property(e => e.provincename)
                .IsUnicode(false);

            modelBuilder.Entity<SubWayClick>()
                .Property(e => e.cityname)
                .IsUnicode(false);

            modelBuilder.Entity<SubWayClick>()
                .Property(e => e.source)
                .IsUnicode(false);

            modelBuilder.Entity<SubWayClick>()
                .Property(e => e.fromPcOrMobile)
                .IsUnicode(false);

            modelBuilder.Entity<SubWayClick>()
                .Property(e => e.keyword)
                .IsUnicode(false);

            modelBuilder.Entity<SuPThesaurus>()
                .Property(e => e.Optimalcategory)
                .IsUnicode(false);

            modelBuilder.Entity<SuPThesaurus>()
                .HasOptional(e => e.SuPThesaurus1)
                .WithRequired(e => e.SuPThesaurus2);

            modelBuilder.Entity<SuRecommend>()
                .Property(e => e.campaignName)
                .IsUnicode(false);

            modelBuilder.Entity<SuRecommend>()
                .Property(e => e.adgroupName)
                .IsUnicode(false);

            modelBuilder.Entity<SuRecommend>()
                .Property(e => e.pic_url)
                .IsUnicode(false);

            modelBuilder.Entity<SYCM_BKSSNew>()
                .Property(e => e.payRateIndex)
                .HasPrecision(20, 7);

            modelBuilder.Entity<SYCM_BKSSNew>()
                .Property(e => e.cltHits)
                .HasPrecision(20, 7);

            modelBuilder.Entity<SYCM_BKSSNew>()
                .Property(e => e.payItemCnt)
                .HasPrecision(20, 7);

            modelBuilder.Entity<SYCM_BKSSNew>()
                .Property(e => e.seIpvUvHits)
                .HasPrecision(20, 7);

            modelBuilder.Entity<SYCM_BKSSNew>()
                .Property(e => e.uvIndex)
                .HasPrecision(20, 7);

            modelBuilder.Entity<SYCM_BKSSNew>()
                .Property(e => e.tradeIndex)
                .HasPrecision(20, 7);

            modelBuilder.Entity<SYCM_BKSSNew>()
                .Property(e => e.cartHits)
                .HasPrecision(20, 7);

            modelBuilder.Entity<SYCM_SCPHPinPai>()
                .Property(e => e.tradeIndex)
                .HasPrecision(18, 3);

            modelBuilder.Entity<SYCM_SCPHPinPai>()
                .Property(e => e.payRateIndex)
                .HasPrecision(18, 3);

            modelBuilder.Entity<SYCM_SCPHPinPai>()
                .Property(e => e.Pay)
                .HasPrecision(18, 3);

            modelBuilder.Entity<SYCM_SCPHPinPai>()
                .Property(e => e.Android)
                .HasPrecision(18, 3);

            modelBuilder.Entity<SYCM_SCPHPinPai>()
                .Property(e => e.payPercent)
                .HasPrecision(18, 3);

            modelBuilder.Entity<SYCM_SCPHPinPai>()
                .Property(e => e.landingUvRatio)
                .HasPrecision(18, 3);

            modelBuilder.Entity<SYCM_SCPHPinPai>()
                .Property(e => e.uvcost)
                .HasPrecision(18, 3);

            modelBuilder.Entity<SYCM_SCPHPinPai>()
                .Property(e => e.itemAmount)
                .HasPrecision(18, 3);

            modelBuilder.Entity<SYCM_ShiChangDaPan>()
                .Property(e => e.SearchPerson)
                .HasPrecision(20, 7);

            modelBuilder.Entity<SYCM_ShiChangDaPan>()
                .Property(e => e.SearchHot)
                .HasPrecision(20, 7);

            modelBuilder.Entity<SYCM_ShiChangDaPan>()
                .Property(e => e.KeQun)
                .HasPrecision(20, 7);

            modelBuilder.Entity<SYCM_ShiChangDaPan>()
                .Property(e => e.Pay)
                .HasPrecision(20, 7);

            modelBuilder.Entity<SYCM_ShiChangPaiHang>()
                .Property(e => e.seIpvUvHits)
                .HasPrecision(20, 7);

            modelBuilder.Entity<SYCM_ShiChangPaiHang>()
                .Property(e => e.uvIndex)
                .HasPrecision(20, 7);

            modelBuilder.Entity<SYCM_ShiChangPaiHang>()
                .Property(e => e.tradeIndex)
                .HasPrecision(20, 7);

            modelBuilder.Entity<SYCM_ShiChangPaiHang>()
                .Property(e => e.zongfangke)
                .HasPrecision(20, 7);

            modelBuilder.Entity<SYCM_ShiChangPaiHang>()
                .Property(e => e.amount)
                .HasPrecision(20, 7);

            modelBuilder.Entity<SYCM_ShiChangPaiHang>()
                .Property(e => e.sousuoRate)
                .HasPrecision(20, 7);

            modelBuilder.Entity<SYCM_ShiChangPaiHang>()
                .Property(e => e.uvjiazhi)
                .HasPrecision(20, 7);

            modelBuilder.Entity<TB_SCDPMonthdata>()
                .Property(e => e.SearchPerson)
                .HasPrecision(20, 7);

            modelBuilder.Entity<TB_SCDPMonthdata>()
                .Property(e => e.SearchHot)
                .HasPrecision(20, 7);

            modelBuilder.Entity<TB_SCDPMonthdata>()
                .Property(e => e.KeQun)
                .HasPrecision(20, 7);

            modelBuilder.Entity<TB_SCDPMonthdata>()
                .Property(e => e.Pay)
                .HasPrecision(20, 7);

            modelBuilder.Entity<TB_SCDPMonthdata>()
                .Property(e => e.SearchUV)
                .HasPrecision(20, 7);

            modelBuilder.Entity<TB_SCDPMonthdata>()
                .Property(e => e.SearchClick)
                .HasPrecision(20, 7);

            modelBuilder.Entity<TB_SCDPMonthdata>()
                .Property(e => e.SellerNumber)
                .HasPrecision(20, 7);

            modelBuilder.Entity<TB_SCDPMonthdata>()
                .Property(e => e.PayMoney)
                .HasPrecision(20, 7);

            modelBuilder.Entity<TB_TaobaoAim>()
                .Property(e => e.FinishPercent)
                .HasPrecision(10, 4);

            modelBuilder.Entity<TB_TaobaoAim>()
                .HasMany(e => e.TB_TaobaoStrategy)
                .WithRequired(e => e.TB_TaobaoAim)
                .HasForeignKey(e => e.AimID);

            modelBuilder.Entity<TB_TaobaoAllFromMobile>()
                .Property(e => e.alipay_convert)
                .HasPrecision(10, 4);

            modelBuilder.Entity<TB_TaobaoAllFromPc>()
                .Property(e => e.percent_landing_pv)
                .HasPrecision(10, 4);

            modelBuilder.Entity<TB_TaobaoAllFromPc>()
                .Property(e => e.percent_pv)
                .HasPrecision(10, 4);

            modelBuilder.Entity<TB_TaobaoAllPenFen>()
                .Property(e => e.DescFen)
                .HasPrecision(5, 4);

            modelBuilder.Entity<TB_TaobaoAllPenFen>()
                .Property(e => e.ServiceFen)
                .HasPrecision(5, 4);

            modelBuilder.Entity<TB_TaobaoAllPenFen>()
                .Property(e => e.SendFen)
                .HasPrecision(5, 4);

            modelBuilder.Entity<TB_TaobaoAllTopMobile>()
                .Property(e => e.roc)
                .HasPrecision(18, 4);

            modelBuilder.Entity<TB_TaobaoAllTopPc>()
                .Property(e => e.roc)
                .HasPrecision(18, 4);

            modelBuilder.Entity<TB_TaoBaoCustomizeCategory>()
                .Property(e => e.CategoryName)
                .IsUnicode(false);

            modelBuilder.Entity<TB_TaoBaoCustomizeCategory>()
                .Property(e => e.FromTable)
                .IsUnicode(false);

            modelBuilder.Entity<TB_TaoBaoCustomizeCategory>()
                .Property(e => e.keyWord)
                .IsUnicode(false);

            modelBuilder.Entity<TB_TaoBaoCustomizeCategory>()
                .Property(e => e.Correlation_ID)
                .IsUnicode(false);

            modelBuilder.Entity<TB_TaobaoDayInfo>()
                .Property(e => e.PayPerent)
                .HasPrecision(10, 4);

            modelBuilder.Entity<TB_TaobaoDayInfo>()
                .Property(e => e.GoPerent)
                .HasPrecision(10, 4);

            modelBuilder.Entity<TB_TaobaoItem>()
                .Property(e => e.factZh)
                .HasPrecision(10, 4);

            modelBuilder.Entity<TB_TaobaoItem>()
                .Property(e => e.factIndustryP)
                .HasPrecision(10, 4);

            modelBuilder.Entity<TB_TaobaoItemWeekDetail>()
                .Property(e => e.DetailName)
                .IsUnicode(false);

            modelBuilder.Entity<TB_TaobaoItemWeekDetail>()
                .Property(e => e.dayNums)
                .IsUnicode(false);

            modelBuilder.Entity<TB_TaobaoItemWeekTask>()
                .Property(e => e.TaskName)
                .IsUnicode(false);

            modelBuilder.Entity<TB_TaobaoItemWeekTask>()
                .Property(e => e.keyword)
                .IsUnicode(false);

            modelBuilder.Entity<TB_TaobaoLzDayInfo>()
                .Property(e => e.trade_repeat_rate)
                .HasPrecision(18, 4);

            modelBuilder.Entity<TB_TaobaoLzDayInfo>()
                .Property(e => e.shop_trade_ex)
                .HasPrecision(18, 4);

            modelBuilder.Entity<TB_TaobaoLzDayInfo>()
                .Property(e => e.ipu)
                .HasPrecision(18, 4);

            modelBuilder.Entity<TB_TaobaoLzDayInfo>()
                .Property(e => e.ext)
                .HasPrecision(18, 4);

            modelBuilder.Entity<TB_TaobaoLzDayInfo>()
                .Property(e => e.today_pay_rate)
                .HasPrecision(18, 4);

            modelBuilder.Entity<TB_TaobaoLzDayInfo>()
                .Property(e => e.auction_roc)
                .HasPrecision(18, 4);

            modelBuilder.Entity<TB_TaobaoLzDayInfo>()
                .Property(e => e.succ_trade_amt)
                .HasPrecision(18, 4);

            modelBuilder.Entity<TB_TaobaoLzDayInfo>()
                .Property(e => e.view_repeat_rate)
                .HasPrecision(18, 4);

            modelBuilder.Entity<TB_TaobaoLzDayInfo>()
                .Property(e => e.roc)
                .HasPrecision(18, 4);

            modelBuilder.Entity<TB_TaobaoLzDayInfoMobile>()
                .Property(e => e.trade_repeat_rate)
                .HasPrecision(18, 4);

            modelBuilder.Entity<TB_TaobaoLzDayInfoMobile>()
                .Property(e => e.shop_trade_ex)
                .HasPrecision(18, 4);

            modelBuilder.Entity<TB_TaobaoLzDayInfoMobile>()
                .Property(e => e.ipu)
                .HasPrecision(18, 4);

            modelBuilder.Entity<TB_TaobaoLzDayInfoMobile>()
                .Property(e => e.ext)
                .HasPrecision(18, 4);

            modelBuilder.Entity<TB_TaobaoLzDayInfoMobile>()
                .Property(e => e.today_pay_rate)
                .HasPrecision(18, 4);

            modelBuilder.Entity<TB_TaobaoLzDayInfoMobile>()
                .Property(e => e.auction_roc)
                .HasPrecision(18, 4);

            modelBuilder.Entity<TB_TaobaoLzDayInfoMobile>()
                .Property(e => e.succ_trade_amt)
                .HasPrecision(18, 4);

            modelBuilder.Entity<TB_TaobaoLzDayInfoMobile>()
                .Property(e => e.view_repeat_rate)
                .HasPrecision(18, 4);

            modelBuilder.Entity<TB_TaobaoLzDayInfoMobile>()
                .Property(e => e.roc)
                .HasPrecision(18, 4);

            modelBuilder.Entity<TB_TaobaoShop>()
                .Property(e => e.SWorkMoney)
                .HasPrecision(5, 1);

            modelBuilder.Entity<TB_TaobaoShop>()
                .Property(e => e.SExpreeMoney)
                .HasPrecision(5, 1);

            modelBuilder.Entity<TB_TaobaoShop>()
                .HasMany(e => e.ApiAccount)
                .WithRequired(e => e.TB_TaobaoShop)
                .HasForeignKey(e => e.ShopID);

            modelBuilder.Entity<TB_TaobaoShop>()
                .HasMany(e => e.ApiDeliveryTemplateR)
                .WithRequired(e => e.TB_TaobaoShop)
                .HasForeignKey(e => e.ShopID);

            modelBuilder.Entity<TB_TaobaoShop>()
                .HasMany(e => e.ApiItem)
                .WithRequired(e => e.TB_TaobaoShop)
                .HasForeignKey(e => e.ShopID);

            modelBuilder.Entity<TB_TaobaoShop>()
                .HasMany(e => e.ApiItemChange)
                .WithRequired(e => e.TB_TaobaoShop)
                .HasForeignKey(e => e.ShopID);

            modelBuilder.Entity<TB_TaobaoShop>()
                .HasMany(e => e.ApiRefund)
                .WithRequired(e => e.TB_TaobaoShop)
                .HasForeignKey(e => e.ShopID);

            modelBuilder.Entity<TB_TaobaoShop>()
                .HasMany(e => e.ApiSellerCats)
                .WithRequired(e => e.TB_TaobaoShop)
                .HasForeignKey(e => e.ShopID);

            modelBuilder.Entity<TB_TaobaoShop>()
                .HasMany(e => e.ApiTradeFlags)
                .WithRequired(e => e.TB_TaobaoShop)
                .HasForeignKey(e => e.ShopID);

            modelBuilder.Entity<TB_TaobaoShop>()
                .HasMany(e => e.ApiTrades2)
                .WithRequired(e => e.TB_TaobaoShop)
                .HasForeignKey(e => e.ShopID);

            modelBuilder.Entity<TB_TaobaoShop>()
                .HasMany(e => e.FactItem)
                .WithRequired(e => e.TB_TaobaoShop)
                .HasForeignKey(e => e.ShopID);

            modelBuilder.Entity<TB_TaobaoShop>()
                .HasMany(e => e.FactItemFrom)
                .WithRequired(e => e.TB_TaobaoShop)
                .HasForeignKey(e => e.ShopID);

            modelBuilder.Entity<TB_TaobaoShop>()
                .HasMany(e => e.FactItemFromHistory)
                .WithRequired(e => e.TB_TaobaoShop)
                .HasForeignKey(e => e.ShopID);

            modelBuilder.Entity<TB_TaobaoShop>()
                .HasMany(e => e.FactItemHistory)
                .WithRequired(e => e.TB_TaobaoShop)
                .HasForeignKey(e => e.ShopID);

            modelBuilder.Entity<TB_TaobaoShop>()
                .HasMany(e => e.FactVistor)
                .WithRequired(e => e.TB_TaobaoShop)
                .HasForeignKey(e => e.ShopID);

            modelBuilder.Entity<TB_TaobaoShop>()
                .HasMany(e => e.ItemIndustryWordsHistory)
                .WithRequired(e => e.TB_TaobaoShop)
                .HasForeignKey(e => e.ShopID);

            modelBuilder.Entity<TB_TaobaoShop>()
                .HasMany(e => e.ItemZtcDateInfo)
                .WithRequired(e => e.TB_TaobaoShop)
                .HasForeignKey(e => e.ShopID);

            modelBuilder.Entity<TB_TaobaoShop>()
                .HasMany(e => e.ItemZtcInfoDetail)
                .WithRequired(e => e.TB_TaobaoShop)
                .HasForeignKey(e => e.ShopID);

            modelBuilder.Entity<TB_TaobaoShop>()
                .HasMany(e => e.ItemZtcInputInfo)
                .WithRequired(e => e.TB_TaobaoShop)
                .HasForeignKey(e => e.ShopID);

            modelBuilder.Entity<TB_TaobaoShop>()
                .HasMany(e => e.JZData)
                .WithRequired(e => e.TB_TaobaoShop)
                .HasForeignKey(e => e.ShopID);

            modelBuilder.Entity<TB_TaobaoShop>()
                .HasMany(e => e.JZItem)
                .WithRequired(e => e.TB_TaobaoShop)
                .HasForeignKey(e => e.ShopID);

            modelBuilder.Entity<TB_TaobaoShop>()
                .HasMany(e => e.JZLostData)
                .WithRequired(e => e.TB_TaobaoShop)
                .HasForeignKey(e => e.ShopID);

            modelBuilder.Entity<TB_TaobaoShop>()
                .HasMany(e => e.JZLostDetail)
                .WithRequired(e => e.TB_TaobaoShop)
                .HasForeignKey(e => e.ShopID);

            modelBuilder.Entity<TB_TaobaoShop>()
                .HasMany(e => e.LL_LiuLiangFromDetail)
                .WithRequired(e => e.TB_TaobaoShop)
                .HasForeignKey(e => e.ShopID);

            modelBuilder.Entity<TB_TaobaoShop>()
                .HasMany(e => e.LL_LiuLiangFromMobile)
                .WithRequired(e => e.TB_TaobaoShop)
                .HasForeignKey(e => e.ShopID);

            modelBuilder.Entity<TB_TaobaoShop>()
                .HasMany(e => e.LL_LiuLiangPc)
                .WithRequired(e => e.TB_TaobaoShop)
                .HasForeignKey(e => e.ShopID);

            modelBuilder.Entity<TB_TaobaoShop>()
                .HasMany(e => e.simba_day)
                .WithRequired(e => e.TB_TaobaoShop)
                .HasForeignKey(e => e.ShopID);

            modelBuilder.Entity<TB_TaobaoShop>()
                .HasMany(e => e.TaskInfoes)
                .WithRequired(e => e.TB_TaobaoShop)
                .HasForeignKey(e => e.ShopID);

            modelBuilder.Entity<TB_TaobaoShop>()
                .HasMany(e => e.TaskKinds)
                .WithRequired(e => e.TB_TaobaoShop)
                .HasForeignKey(e => e.ShopID);

            modelBuilder.Entity<TB_TaobaoShop>()
                .HasMany(e => e.TB_TaobaoAllCartCollect)
                .WithRequired(e => e.TB_TaobaoShop)
                .HasForeignKey(e => e.ShopID);

            modelBuilder.Entity<TB_TaobaoShop>()
                .HasMany(e => e.TB_TaobaoAllFromMobile)
                .WithRequired(e => e.TB_TaobaoShop)
                .HasForeignKey(e => e.ShopID);

            modelBuilder.Entity<TB_TaobaoShop>()
                .HasMany(e => e.TB_TaobaoAllFromPc)
                .WithRequired(e => e.TB_TaobaoShop)
                .HasForeignKey(e => e.ShopID);

            modelBuilder.Entity<TB_TaobaoShop>()
                .HasMany(e => e.TB_TaobaoAllHome)
                .WithRequired(e => e.TB_TaobaoShop)
                .HasForeignKey(e => e.ShopID);

            modelBuilder.Entity<TB_TaobaoShop>()
                .HasMany(e => e.TB_TaobaoAllPenFen)
                .WithRequired(e => e.TB_TaobaoShop)
                .HasForeignKey(e => e.ShopID);

            modelBuilder.Entity<TB_TaobaoShop>()
                .HasMany(e => e.TB_TaobaoAllTopMobile)
                .WithRequired(e => e.TB_TaobaoShop)
                .HasForeignKey(e => e.ShopID);

            modelBuilder.Entity<TB_TaobaoShop>()
                .HasMany(e => e.TB_TaobaoAllTopPc)
                .WithRequired(e => e.TB_TaobaoShop)
                .HasForeignKey(e => e.ShopID);

            modelBuilder.Entity<TB_TaobaoShop>()
                .HasMany(e => e.TB_TaobaoAllWW)
                .WithRequired(e => e.TB_TaobaoShop)
                .HasForeignKey(e => e.ShopID);

            modelBuilder.Entity<TB_TaobaoShop>()
                .HasMany(e => e.TB_TaobaoAllZx)
                .WithRequired(e => e.TB_TaobaoShop)
                .HasForeignKey(e => e.ShopID);

            modelBuilder.Entity<TB_TaobaoShop>()
                .HasMany(e => e.TB_TaobaoDayInfo)
                .WithRequired(e => e.TB_TaobaoShop)
                .HasForeignKey(e => e.ShopID);

            modelBuilder.Entity<TB_TaobaoShop>()
                .HasMany(e => e.TB_TaobaoDaySellInfo)
                .WithRequired(e => e.TB_TaobaoShop)
                .HasForeignKey(e => e.ShopID);

            modelBuilder.Entity<TB_TaobaoShop>()
                .HasMany(e => e.TB_TaobaoDaySellInfoMobile)
                .WithRequired(e => e.TB_TaobaoShop)
                .HasForeignKey(e => e.ShopID);

            modelBuilder.Entity<TB_TaobaoShop>()
                .HasMany(e => e.TB_TaobaoDDS)
                .WithRequired(e => e.TB_TaobaoShop)
                .HasForeignKey(e => e.ShopID);

            modelBuilder.Entity<TB_TaobaoShop>()
                .HasMany(e => e.TB_TaobaoItem)
                .WithRequired(e => e.TB_TaobaoShop)
                .HasForeignKey(e => e.ShopID);

            modelBuilder.Entity<TB_TaobaoShop>()
                .HasMany(e => e.TB_TaobaoItemAd)
                .WithRequired(e => e.TB_TaobaoShop)
                .HasForeignKey(e => e.ShopID);

            modelBuilder.Entity<TB_TaobaoShop>()
                .HasMany(e => e.TB_TaobaoItemAim)
                .WithRequired(e => e.TB_TaobaoShop)
                .HasForeignKey(e => e.ShopID);

            modelBuilder.Entity<TB_TaobaoShop>()
                .HasMany(e => e.TB_TaobaoItemDiamondShow)
                .WithRequired(e => e.TB_TaobaoShop)
                .HasForeignKey(e => e.ShopID);

            modelBuilder.Entity<TB_TaobaoShop>()
                .HasMany(e => e.TB_TaobaoItemExt)
                .WithRequired(e => e.TB_TaobaoShop)
                .HasForeignKey(e => e.ShopID);

            modelBuilder.Entity<TB_TaobaoShop>()
                .HasMany(e => e.TB_TaobaoItemInfoMobile)
                .WithRequired(e => e.TB_TaobaoShop)
                .HasForeignKey(e => e.ShopID);

            modelBuilder.Entity<TB_TaobaoShop>()
                .HasMany(e => e.TB_TaobaoItemMarketing)
                .WithRequired(e => e.TB_TaobaoShop)
                .HasForeignKey(e => e.ShopID);

            modelBuilder.Entity<TB_TaobaoShop>()
                .HasMany(e => e.TB_TaobaoItemPicModify)
                .WithRequired(e => e.TB_TaobaoShop)
                .HasForeignKey(e => e.ShopID);

            modelBuilder.Entity<TB_TaobaoShop>()
                .HasMany(e => e.TB_TaobaoItemSeo)
                .WithRequired(e => e.TB_TaobaoShop)
                .HasForeignKey(e => e.ShopID);

            modelBuilder.Entity<TB_TaobaoShop>()
                .HasMany(e => e.TB_TaobaoItemStrategy)
                .WithRequired(e => e.TB_TaobaoShop)
                .HasForeignKey(e => e.ShopID);

            modelBuilder.Entity<TB_TaobaoShop>()
                .HasMany(e => e.TB_TaobaoItemTag)
                .WithRequired(e => e.TB_TaobaoShop)
                .HasForeignKey(e => e.ShopID);

            modelBuilder.Entity<TB_TaobaoShop>()
                .HasMany(e => e.TB_TaobaoItemTagType)
                .WithRequired(e => e.TB_TaobaoShop)
                .HasForeignKey(e => e.ShopID);

            modelBuilder.Entity<TB_TaobaoShop>()
                .HasMany(e => e.TB_TaobaoItemVCus)
                .WithRequired(e => e.TB_TaobaoShop)
                .HasForeignKey(e => e.ShopID);

            modelBuilder.Entity<TB_TaobaoShop>()
                .HasMany(e => e.TB_TaobaoItemVCusOther)
                .WithRequired(e => e.TB_TaobaoShop)
                .HasForeignKey(e => e.ShopID);

            modelBuilder.Entity<TB_TaobaoShop>()
                .HasMany(e => e.TB_TaobaoItemWeekPlan)
                .WithRequired(e => e.TB_TaobaoShop)
                .HasForeignKey(e => e.ShopID);

            modelBuilder.Entity<TB_TaobaoShop>()
                .HasMany(e => e.TB_TaobaoLzDayInfo)
                .WithRequired(e => e.TB_TaobaoShop)
                .HasForeignKey(e => e.ShopID);

            modelBuilder.Entity<TB_TaobaoShop>()
                .HasMany(e => e.TB_TaobaoLzDayInfoMobile)
                .WithRequired(e => e.TB_TaobaoShop)
                .HasForeignKey(e => e.ShopID);

            modelBuilder.Entity<TB_TaobaoShop>()
                .HasMany(e => e.YSF_shop_wireless_platform_src_new_d)
                .WithRequired(e => e.TB_TaobaoShop)
                .HasForeignKey(e => e.ShopID);

            modelBuilder.Entity<TB_TaobaoShop>()
                .HasMany(e => e.TB_TaobaoShua)
                .WithRequired(e => e.TB_TaobaoShop)
                .HasForeignKey(e => e.ShopID);

            modelBuilder.Entity<TB_TaobaoShop>()
                .HasMany(e => e.TB_TaobaoShuaAll)
                .WithRequired(e => e.TB_TaobaoShop)
                .HasForeignKey(e => e.ShopID);

            modelBuilder.Entity<TB_TaobaoShop>()
                .HasMany(e => e.TB_TaobaoSimba3Days)
                .WithRequired(e => e.TB_TaobaoShop)
                .HasForeignKey(e => e.ShopID);

            modelBuilder.Entity<TB_TaobaoShop>()
                .HasMany(e => e.TB_TaobaoSimbaFull)
                .WithRequired(e => e.TB_TaobaoShop)
                .HasForeignKey(e => e.ShopID);

            modelBuilder.Entity<TB_TaobaoShop>()
                .HasMany(e => e.TB_TaobaoSimbaToday)
                .WithRequired(e => e.TB_TaobaoShop)
                .HasForeignKey(e => e.ShopID);

            modelBuilder.Entity<TB_TaobaoShop>()
                .HasMany(e => e.YSF_auction_app_query_effect_new_d)
                .WithRequired(e => e.TB_TaobaoShop)
                .HasForeignKey(e => e.ShopID);

            modelBuilder.Entity<TB_TaobaoShop>()
                .HasMany(e => e.YSF_auction_comment_d)
                .WithRequired(e => e.TB_TaobaoShop)
                .HasForeignKey(e => e.ShopID);

            modelBuilder.Entity<TB_TaobaoShop>()
                .HasMany(e => e.YSF_auction_pc_search_src_effect_new_d)
                .WithRequired(e => e.TB_TaobaoShop)
                .HasForeignKey(e => e.ShopID);

            modelBuilder.Entity<TB_TaobaoShop>()
                .HasMany(e => e.YSF_auction_pc_src_effect_d)
                .WithRequired(e => e.TB_TaobaoShop)
                .HasForeignKey(e => e.ShopID);

            modelBuilder.Entity<TB_TaobaoShop>()
                .HasMany(e => e.YSF_auction_platform_trade_d)
                .WithRequired(e => e.TB_TaobaoShop)
                .HasForeignKey(e => e.ShopID);

            modelBuilder.Entity<TB_TaobaoShop>()
                .HasMany(e => e.YSF_auction_query_effect_d)
                .WithRequired(e => e.TB_TaobaoShop)
                .HasForeignKey(e => e.ShopID);

            modelBuilder.Entity<TB_TaobaoShop>()
                .HasMany(e => e.YSF_auction_trade_src_d)
                .WithRequired(e => e.TB_TaobaoShop)
                .HasForeignKey(e => e.ShopID);

            modelBuilder.Entity<TB_TaobaoShop>()
                .HasMany(e => e.YSF_item_3)
                .WithRequired(e => e.TB_TaobaoShop)
                .HasForeignKey(e => e.ShopID);

            modelBuilder.Entity<TB_TaobaoShop>()
                .HasMany(e => e.YSF_item_app_src_platform_new_d)
                .WithRequired(e => e.TB_TaobaoShop)
                .HasForeignKey(e => e.ShopID);

            modelBuilder.Entity<TB_TaobaoShop>()
                .HasMany(e => e.YSF_item_search_effect_new_d)
                .WithRequired(e => e.TB_TaobaoShop)
                .HasForeignKey(e => e.ShopID);

            modelBuilder.Entity<TB_TaobaoShop>()
                .HasMany(e => e.YSF_item_source_last_effect_new_d)
                .WithRequired(e => e.TB_TaobaoShop)
                .HasForeignKey(e => e.ShopID);

            modelBuilder.Entity<TB_TaobaoShop>()
                .HasMany(e => e.YSF_pc_search_src_effect_d)
                .WithRequired(e => e.TB_TaobaoShop)
                .HasForeignKey(e => e.ShopID);

            modelBuilder.Entity<TB_TaobaoShop>()
                .HasMany(e => e.YSF_platform_source_traffic_d)
                .WithRequired(e => e.TB_TaobaoShop)
                .HasForeignKey(e => e.ShopID);

            modelBuilder.Entity<TB_TaobaoShop>()
                .HasMany(e => e.YSF_shop_1)
                .WithRequired(e => e.TB_TaobaoShop)
                .HasForeignKey(e => e.ShopID);

            modelBuilder.Entity<TB_TaobaoShop>()
                .HasMany(e => e.YSF_shop_2)
                .WithRequired(e => e.TB_TaobaoShop)
                .HasForeignKey(e => e.ShopID);

            modelBuilder.Entity<TB_TaobaoShop>()
                .HasMany(e => e.YSF_shop_src_last_effect_d)
                .WithRequired(e => e.TB_TaobaoShop)
                .HasForeignKey(e => e.ShopID);

            modelBuilder.Entity<TB_TaobaoShop>()
                .HasMany(e => e.YSF_new_shop_weblog_d)
                .WithRequired(e => e.TB_TaobaoShop)
                .HasForeignKey(e => e.ShopID);

            modelBuilder.Entity<TB_TaobaoShop>()
                .HasMany(e => e.YSF_new_shop_wireless_log_d_all)
                .WithRequired(e => e.TB_TaobaoShop)
                .HasForeignKey(e => e.ShopID);

            modelBuilder.Entity<TB_TaobaoShop>()
                .HasMany(e => e.YSF_sku_trade_d)
                .WithRequired(e => e.TB_TaobaoShop)
                .HasForeignKey(e => e.ShopID);

            modelBuilder.Entity<TB_TaobaoShop>()
                .HasMany(e => e.TB_ZTCTool)
                .WithRequired(e => e.TB_TaobaoShop)
                .HasForeignKey(e => e.ShopID);

            modelBuilder.Entity<TB_TaobaoShop>()
                .HasMany(e => e.ZWShopPlan)
                .WithRequired(e => e.TB_TaobaoShop)
                .HasForeignKey(e => e.ShopID);

            modelBuilder.Entity<TB_TaobaoSimba3Days>()
                .Property(e => e.effect_rank)
                .HasPrecision(18, 4);

            modelBuilder.Entity<TB_TaobaoSimba3Days>()
                .Property(e => e.efficiency)
                .HasPrecision(18, 4);

            modelBuilder.Entity<TB_TaobaoSimba3Days>()
                .Property(e => e.roc)
                .HasPrecision(18, 4);

            modelBuilder.Entity<TB_TaobaoSimbaFull>()
                .Property(e => e.roc)
                .HasPrecision(18, 4);

            modelBuilder.Entity<TB_TaobaoSimbaFull>()
                .Property(e => e.efficiency)
                .HasPrecision(18, 4);

            modelBuilder.Entity<TB_TaobaoSimbaToday>()
                .Property(e => e.effect_rank)
                .HasPrecision(18, 4);

            modelBuilder.Entity<TB_TaobaoSimbaToday>()
                .Property(e => e.efficiency)
                .HasPrecision(18, 4);

            modelBuilder.Entity<TB_TaobaoSimbaToday>()
                .Property(e => e.roc)
                .HasPrecision(18, 4);

            modelBuilder.Entity<TB_ZTCTool>()
                .Property(e => e.showPercent)
                .HasPrecision(5, 2);

            modelBuilder.Entity<TB_ZTCTool>()
                .Property(e => e.clickPercent)
                .HasPrecision(5, 2);

            modelBuilder.Entity<TB_ZTCTool>()
                .Property(e => e.price)
                .HasPrecision(8, 2);

            modelBuilder.Entity<TB_ZTCTool>()
                .Property(e => e.clickChangeP)
                .HasPrecision(5, 2);

            modelBuilder.Entity<UserItemRole>()
                .Property(e => e.liv)
                .IsUnicode(false);

            modelBuilder.Entity<UserWebRole>()
                .Property(e => e.liv)
                .IsUnicode(false);

            modelBuilder.Entity<ZWCateTagTypeInfo>()
                .Property(e => e.searchAddRange)
                .HasPrecision(20, 7);

            modelBuilder.Entity<ZWCateTagTypeInfo>()
                .Property(e => e.clickPercent)
                .HasPrecision(20, 7);

            modelBuilder.Entity<ZWCateTagTypeInfo>()
                .Property(e => e.payPercent)
                .HasPrecision(20, 7);
        }
    }
}
