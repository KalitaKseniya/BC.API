using BC.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BC.API.Infrastructure.Configuration
{
    public class ManufacturerConfiguration : IEntityTypeConfiguration<Manufacturer>
	{
		public void Configure(EntityTypeBuilder<Manufacturer> builder)
		{
			builder.HasKey(x => x.Id);
						
			builder.HasMany(x => x.PartModels)
				.WithOne(pm => pm.Manufacturer)
				.HasForeignKey(x => x.ManufacturerId);
		}
	}
}
