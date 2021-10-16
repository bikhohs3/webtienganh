namespace web.Models.test
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Cauhoi")]
    public partial class Cauhoi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cauhoi()
        {
            Chitietdiems = new HashSet<Chitietdiem>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int maCauhoi { get; set; }

        [StringLength(50)]
        public string tenCauhoi { get; set; }

        public int? diemCauhoi { get; set; }

        [StringLength(30)]
        public string cauTraloi1 { get; set; }

        [StringLength(30)]
        public string cauTraloi2 { get; set; }

        [StringLength(30)]
        public string cauTraloi3 { get; set; }

        [StringLength(30)]
        public string cauTraloi4 { get; set; }

        [Column(TypeName = "image")]
        public byte[] hinhAnh { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int maTu { get; set; }

        public virtual Tuvung Tuvung { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Chitietdiem> Chitietdiems { get; set; }
    }
}
