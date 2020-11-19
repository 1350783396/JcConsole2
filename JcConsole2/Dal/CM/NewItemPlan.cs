namespace Dal.CM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NewItemPlan")]
    public partial class NewItemPlan
    {
        public int id { get; set; }

        public int shopid { get; set; }

        public long itemid { get; set; }

        public int? order_plan_num { get; set; }

        public decimal? industry_rate { get; set; }

        public int? order_fact_num { get; set; }

        public int? item_visit_num { get; set; }

        public decimal? item_detal_amount { get; set; }

        public int? brush_single_num { get; set; }

        public decimal? re_order_amount { get; set; }

        public int? mobile_search_uv { get; set; }

        public int? mobile_search_deal_indirectbe { get; set; }

        public int? mobile_search_deal_directbe { get; set; }

        public decimal? mobile_deal_amount { get; set; }

        public DateTime thedate { get; set; }

        public int? ItemConfig { get; set; }

        [StringLength(50)]
        public string mude_rate { get; set; }

        [StringLength(300)]
        public string remark { get; set; }

        [StringLength(300)]
        public string keyWord { get; set; }

        public decimal? predictSaleroom { get; set; }

        public decimal? costEstimate { get; set; }

        public int? predictPayuv { get; set; }
    }
}
