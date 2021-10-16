namespace web.Models.test
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Cauhoi> Cauhois { get; set; }
        public virtual DbSet<Dangky> Dangkies { get; set; }
        public virtual DbSet<Detai> Detais { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Tuvung> Tuvungs { get; set; }
        public virtual DbSet<Chitietdiem> Chitietdiems { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cauhoi>()
                .HasMany(e => e.Chitietdiems)
                .WithRequired(e => e.Cauhoi)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Dangky>()
                .HasMany(e => e.Chitietdiems)
                .WithRequired(e => e.Dangky)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Tuvung>()
                .HasMany(e => e.Cauhois)
                .WithRequired(e => e.Tuvung)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Tuvung>()
                .HasMany(e => e.Chitietdiems)
                .WithRequired(e => e.Tuvung)
                .WillCascadeOnDelete(false);
        }
    }
}
