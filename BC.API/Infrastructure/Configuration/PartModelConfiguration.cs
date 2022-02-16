using BC.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BC.API.Infrastructure.Configuration
{
    public class PartModelConfiguration : IEntityTypeConfiguration<PartModel>
	{
		public void Configure(EntityTypeBuilder<PartModel> builder)
		{
			builder.HasKey(x => x.Id);

			builder.HasOne(x => x.Manufacturer)
				.WithMany(pm => pm.PartModels)
				.HasForeignKey(pm => pm.ManufacturerId);

			builder.HasOne(x => x.Part)
				.WithMany(pm => pm.PartModels)
				.HasForeignKey(pm => pm.PartId);
			//ToDo K: configure many-to-many
		}
	}
}
