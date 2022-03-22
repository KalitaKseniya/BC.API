using BC.API.Infrastructure.Configuration;
using BC.API.Models;
using Microsoft.EntityFrameworkCore;

namespace BC.API.Infrastructure
{
    public class RepositoryContext : DbContext
    {
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Bicycle> Bicycles { get; set; }
        public DbSet<Problem> Problems { get; set; }
        public DbSet<PartModelProblem> PartModelProblems { get; set; }
        public DbSet<Part> Parts { get; set; }
        public DbSet<PartModel> PartModels { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }

        public RepositoryContext(DbContextOptions<RepositoryContext> opt) : base(opt)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AddressConfiguration());
            modelBuilder.ApplyConfiguration(new BicycleConfiguration());
            modelBuilder.ApplyConfiguration(new PartConfiguration());
            modelBuilder.ApplyConfiguration(new ManufacturerConfiguration());
            modelBuilder.ApplyConfiguration(new PartModelConfiguration());
            modelBuilder.ApplyConfiguration(new PartModelProblemConfiguration());
            modelBuilder.ApplyConfiguration(new ProblemConfiguration());

            modelBuilder.ApplyConfiguration(new ProviderConfiguration());
            modelBuilder.ApplyConfiguration(new DeliveryOrderPartModelsConfiguration());
            modelBuilder.ApplyConfiguration(new DeliveryOrderConfiguration());
        }
    }

}
