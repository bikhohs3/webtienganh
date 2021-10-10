namespace web.Models.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("User")]
    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            Chitietdiems = new HashSet<Chitietdiem>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int diem { get; set; }

        [StringLength(20)]
        public string tenNhanvat { get; set; }

        public int? tongDiem { get; set; }

        public int? sdt { get; set; }

        public int? maUser { get; set; }

        public virtual Dangky Dangky { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Chitietdiem> Chitietdiems { get; set; }
    }
}
