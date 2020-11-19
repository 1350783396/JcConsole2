namespace Dal.CM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SuPThesaurus
    {
        public int id { get; set; }

        public int clickHits { get; set; }

        public int clickHot { get; set; }

        public decimal clickRate { get; set; }

        [Required]
        [StringLength(64)]
        public string keyword { get; set; }

        public int onlineGoodsCnt { get; set; }

        public decimal p4pAmt { get; set; }

        public decimal payConvRate { get; set; }

        public int seIpvUvHits { get; set; }

        public int sePvIndex { get; set; }

        public decimal tmClickRatio { get; set; }

        public decimal GoldValue { get; set; }

        public decimal BlueSea { get; set; }

        public int seManNum { get; set; }

        public int SeClick { get; set; }

        public decimal unitPrice { get; set; }

        public int payMenNum { get; set; }

        public decimal dealAmt { get; set; }

        public int tradeIndex { get; set; }

        [Required]
        [StringLength(100)]
        public string Optimalcategory { get; set; }

        public int impressionIndex { get; set; }

        public decimal impressionRatio { get; set; }

        public decimal ctr { get; set; }

        public int clickIndex { get; set; }

        public decimal avgPrice { get; set; }

        public decimal cvr { get; set; }

        public int competition { get; set; }

        public int PimpressionIndex { get; set; }

        public decimal PimpressionRatio { get; set; }

        public decimal Pctr { get; set; }

        public int PclickIndex { get; set; }

        public decimal PavgPrice { get; set; }

        public decimal Pcvr { get; set; }

        public int Pcompetition { get; set; }

        public int cateId { get; set; }

        public int BcateId { get; set; }

        public int shopid { get; set; }

        public bool isback { get; set; }

        public virtual SuPThesaurus SuPThesaurus1 { get; set; }

        public virtual SuPThesaurus SuPThesaurus2 { get; set; }
    }
}
