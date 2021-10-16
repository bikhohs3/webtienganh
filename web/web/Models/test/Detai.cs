namespace web.Models.test
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Detai")]
    public partial class Detai
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Detai()
        {
            Tuvungs = new HashSet<Tuvung>();
        }

        [Key]
        public int maDetai { get; set; }

        [StringLength(30)]
        public string tenDetai { get; set; }

        [StringLength(30)]
        public string tenDetaita { get; set; }

        public string image { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tuvung> Tuvungs { get; set; }
    }
}
