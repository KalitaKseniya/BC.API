using BC.API.Infrastructure.Configuration;
using BC.API.Models;
using Microsoft.EntityFrameworkCore;

namespace BC.API.Infrastructure
{
    public class RepositoryContext : DbContext//ToDo K: configure ef
    {
        public DbSet<Address> Addresses { get; set; }
        public DbSet<BicycleConfiguration> Bicycles { get; set; }
        public DbSet<DeliveryOrder> DeliveryOrders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AddressConfiguration());
            modelBuilder.ApplyConfiguration(new BicycleConfiguration());
            modelBuilder.ApplyConfiguration(new DeliveryOrderConfiguration());
        }
    }

}
