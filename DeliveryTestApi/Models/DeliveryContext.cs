using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;


namespace DeliveryTestApi.Models
{
    public class DeliveryContext : DbContext
    {
        public DeliveryContext()
        {

        }
        public DeliveryContext(DbContextOptions<DeliveryContext> options) : base(options)
        {

        }

        //public virtual DbSet<>
        public virtual DbSet<Cliente> Clientes { get; set; } = null!;
        public virtual DbSet<Producto> Productos { get; set; } = null!;
        public virtual DbSet<Empleado> Empleados { get; set; } = null!;
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.HasKey(e => e.ClienteId).HasName("PK__Cliente__71ABD087930DA599");
                entity.ToTable("Cliente");
            });
            
            modelBuilder.Entity<Empleado>(entity =>
            {
                entity.HasKey(e => e.IdEmpleado).HasName("PK__Empleado__CE6D8B9E2C560007");
                entity.ToTable("Empleado");
            });

            modelBuilder.Entity<Producto>(entity =>
            {
                entity.HasKey(e => e.IdProducto).HasName("PK__Producto__0988921043559C1F");
                entity.ToTable("Producto");
            });
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-H6T08LD\\SORROPERRO;Database=DbDelivery;Integrated security=true");
            }
        }


    }
}
