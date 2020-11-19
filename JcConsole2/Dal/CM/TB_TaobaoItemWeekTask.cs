namespace Dal.CM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_TaobaoItemWeekTask
    {
        public int id { get; set; }

        [StringLength(150)]
        public string TaskName { get; set; }

        public decimal? Trget { get; set; }

        public decimal? Fact { get; set; }

        public int? DetailId { get; set; }

        [StringLength(50)]
        public string keyword { get; set; }

        public int? CustomizeID { get; set; }
    }
}
