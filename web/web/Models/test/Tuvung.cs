namespace web.Models.test
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Tuvung")]
    public partial class Tuvung
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tuvung()
        {
            Cauhois = new HashSet<Cauhoi>();
            Chitietdiems = new HashSet<Chitietdiem>();
        }

        [Key]
        public int maTu { get; set; }

        [StringLength(50)]
        public string tenTuta { get; set; }

        [StringLength(50)]
        public string tenTu { get; set; }

        public int? maDetai { get; set; }

        public string image { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cauhoi> Cauhois { get; set; }

        public virtual Detai Detai { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Chitietdiem> Chitietdiems { get; set; }
    }
}
