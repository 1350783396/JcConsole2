namespace Dal.CM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserWebRole")]
    public partial class UserWebRole
    {
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string liv { get; set; }

        public Guid uuid { get; set; }

        public int shopId { get; set; }

        public int? ConfigId { get; set; }

        public Guid Creater { get; set; }

        public DateTime createtime { get; set; }
    }
}
