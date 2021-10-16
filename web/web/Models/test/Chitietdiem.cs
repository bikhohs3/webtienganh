namespace web.Models.test
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Chitietdiem")]
    public partial class Chitietdiem
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int maUser { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int maTu { get; set; }

        [Key]
        [Column(Order = 2)]
        public int maCauhoi { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int diem { get; set; }

        public virtual Cauhoi Cauhoi { get; set; }

        public virtual Dangky Dangky { get; set; }

        public virtual Tuvung Tuvung { get; set; }
    }
}
