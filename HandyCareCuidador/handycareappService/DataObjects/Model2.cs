namespace handycareappService.DataObjects
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model2 : DbContext
    {
        public Model2()
            : base("name=Model2")
        {
        }

        public virtual DbSet<Camera> Camera { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Camera>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<Camera>()
                .Property(e => e.CamFamiliar)
                .IsUnicode(false);

            modelBuilder.Entity<Camera>()
                .Property(e => e.CamIPv4)
                .IsUnicode(false);

            modelBuilder.Entity<Camera>()
                .Property(e => e.CamIPv6)
                .IsUnicode(false);
        }
    }
}
