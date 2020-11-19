namespace Dal.CM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserItemRole")]
    public partial class UserItemRole
    {
        public int id { get; set; }

        public long? itemid { get; set; }

        [Required]
        [StringLength(50)]
        public string liv { get; set; }

        public Guid Creater { get; set; }

        public int shopId { get; set; }

        public DateTime createtime { get; set; }

        public Guid uuid { get; set; }
    }
}
