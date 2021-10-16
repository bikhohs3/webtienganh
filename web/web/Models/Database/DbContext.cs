namespace web.Models.Database
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Web;

    using web;
    using System.Collections.Generic;

    public partial class DbContext1 : DbContext
    {
        public DbContext1()
            : base("name=DbContext1")
        {

        }
        public static IEnumerable<Detai> Danhsach()
        {
            var db = new DbContext1();
            return db.Detais.SqlQuery("select * from Detai");
        }

        public static IEnumerable<Tuvung> Tu(string id)
        {
            var db = new DbContext1();
            return db.Tuvungs.SqlQuery("select * from Tuvung where maDetai = '" + id + "'");
        }

        public static IEnumerable<Dangky> Dangky()
        {
            var db = new DbContext1();
            return db.Dangkies.SqlQuery("insert into Dangky values * ");

        }

        public static IEnumerable<Dangky> Login(int sdt)
        {
            var db = new DbContext1();
            return db.Dangkies.SqlQuery("select * from Dangky where sdt = '" + sdt + "'");
        }
      
       
        //public static Detai ChiTiet(String a)
        //{
        //    var db = new DbContext1();
        //    return db.SingleOrDefault<Detai>("select * from Detai where maDetai = @0", a);
        //}

        //private T SingleOrDefault<T>(string v, string a)
        //{
        //    throw new NotImplementedException();
        //}

        //private IEnumerable<T> Query<T>(string v)
        //{
        //    throw new NotImplementedException();
        //}

        public virtual DbSet<Cauhoi> Cauhois { get; set; }
        public virtual DbSet<Detai> Detais { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Tuvung> Tuvungs { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Dangky> Dangkies { get; set; }
        public virtual DbSet<Chitietdiem> Chitietdiems { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cauhoi>()
                .HasMany(e => e.Chitietdiems)
                .WithRequired(e => e.Cauhoi)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Tuvung>()
                .HasMany(e => e.Cauhois)
                .WithRequired(e => e.Tuvung)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Tuvung>()
                .HasMany(e => e.Chitietdiems)
                .WithRequired(e => e.Tuvung)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Chitietdiems)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);
        }
    }
}
