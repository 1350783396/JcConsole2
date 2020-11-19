namespace Dal.CM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ApiTopFeeRs
    {
        public int id { get; set; }

        [StringLength(64)]
        public string service_type { get; set; }

        [Required]
        [StringLength(800)]
        public string destination { get; set; }

        public decimal start_standard { get; set; }

        public decimal start_fee { get; set; }

        public decimal add_standard { get; set; }

        public decimal add_fee { get; set; }

        public long template_id { get; set; }

        public virtual ApiDeliveryTemplateR ApiDeliveryTemplateR { get; set; }
    }
}
