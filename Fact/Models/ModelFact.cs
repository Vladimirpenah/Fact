namespace Fact.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ModelFact : DbContext
    {
        public ModelFact()
            : base("name=ModelFact")
        {
        }

        public virtual DbSet<articulo> articulo { get; set; }
        public virtual DbSet<cliente> cliente { get; set; }
        public virtual DbSet<empleado> empleado { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<articulo>()
                .Property(e => e.DescripcionArticulo)
                .IsUnicode(false);

            modelBuilder.Entity<articulo>()
                .Property(e => e.Estado)
                .IsUnicode(false);

            modelBuilder.Entity<cliente>()
                .Property(e => e.NombreComercial)
                .IsUnicode(false);

            modelBuilder.Entity<cliente>()
                .Property(e => e.DocIdentificacion)
                .IsUnicode(false);

            modelBuilder.Entity<cliente>()
                .Property(e => e.Estado)
                .IsUnicode(false);

            modelBuilder.Entity<empleado>()
                .Property(e => e.NombreEmpleado)
                .IsUnicode(false);

            modelBuilder.Entity<empleado>()
                .Property(e => e.Estado)
                .IsUnicode(false);
        }
    }
}
