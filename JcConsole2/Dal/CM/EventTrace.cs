namespace Dal.CM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EventTrace")]
    public partial class EventTrace
    {
        public int id { get; set; }

        public DateTime? thedate { get; set; }

        public long? jzitemId { get; set; }

        public long? shopId { get; set; }

        public DateTime? updateDate { get; set; }

        public string text { get; set; }

        public int isJP { get; set; }

        public int? traceType { get; set; }

        public Guid? userid { get; set; }

        public Guid? company { get; set; }

        public int? isFeedback { get; set; }
    }
}
