namespace handycareappService.DataObjects
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

        public virtual DbSet<Foto> Foto { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Foto>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<Foto>()
                .Property(e => e.FotoDescricao)
                .IsUnicode(false);

            modelBuilder.Entity<Foto>()
                .Property(e => e.FotCuidador)
                .IsUnicode(false);

            modelBuilder.Entity<Foto>()
                .Property(e => e.Version)
                .IsFixedLength();
        }
    }
}
