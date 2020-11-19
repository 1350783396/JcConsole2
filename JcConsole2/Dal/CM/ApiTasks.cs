namespace Dal.CM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ApiTasks
    {
        public int id { get; set; }

        public int TaskTpe { get; set; }

        public int ShopId { get; set; }

        [Required]
        [StringLength(64)]
        public string UserId { get; set; }

        public DateTime Created { get; set; }

        public DateTime? Finish { get; set; }

        public DateTime? Start { get; set; }

        public string Error { get; set; }

        public bool IsError { get; set; }
    }
}
