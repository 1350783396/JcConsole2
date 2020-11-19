namespace Dal.CM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class KeyWord_Marker1
    {
        [Key]
        [Column(Order = 0)]
        public int id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int shop_id { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long item_id { get; set; }

        [StringLength(64)]
        public string keyword { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int deveice { get; set; }

        [Key]
        [Column(Order = 4)]
        public bool isFocus_keyword { get; set; }

        [Key]
        [Column(Order = 5)]
        public bool isCore_keyword { get; set; }

        [Key]
        [Column(Order = 6)]
        public bool isKeyPoint_keyword { get; set; }

        [Key]
        [Column(Order = 7)]
        public bool isBigWord_keyword { get; set; }
    }
}
