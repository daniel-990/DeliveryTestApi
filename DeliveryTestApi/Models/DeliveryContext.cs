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
        public DbSet<Cliente> Cliente { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-H6T08LD\\SORROPERRO;Database=DbDelivery;Integrated security=true");
            }
        }


    }
}
