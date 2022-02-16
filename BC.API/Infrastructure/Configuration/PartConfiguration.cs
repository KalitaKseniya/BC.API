using BC.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BC.API.Infrastructure.Configuration
{
    public class PartConfiguration : IEntityTypeConfiguration<Part>
	{
		public void Configure(EntityTypeBuilder<Part> builder)
		{
			builder.HasKey(x => x.Id);

			builder.HasMany(x => x.PartModels)
				.WithOne(pm => pm.Part)
				.HasForeignKey(pm => pm.PartId);
			
			builder.HasMany(x => x.PartModelProblems)
				.WithOne(pm => pm.Part)
				.HasForeignKey(pm => pm.PartId);
		}
	}
}
