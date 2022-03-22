using BC.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BC.API.Infrastructure.Configuration
{
	public class BicycleConfiguration : IEntityTypeConfiguration<Bicycle>
	{
		public void Configure(EntityTypeBuilder<Bicycle> builder)
		{
			builder.HasKey(x => x.Id);

			builder.Property(m => m.Model)
				.HasMaxLength(255)
				.IsRequired();
				
			builder.Property(m => m.SerialNumber)
				.HasMaxLength(255);

			builder.HasMany(b => b.Problems)
				.WithOne(p => p.Bicycle)
				.HasForeignKey(p => p.BicycleId);
		}
	}
}
