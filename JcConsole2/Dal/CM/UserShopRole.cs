namespace Dal.CM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserShopRole")]
    public partial class UserShopRole
    {
        public int id { get; set; }

        public Guid userid { get; set; }

        public int shopid { get; set; }
    }
}
