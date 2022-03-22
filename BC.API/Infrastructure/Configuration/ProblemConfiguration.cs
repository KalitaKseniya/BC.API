using BC.API.Models;
using BC.API.Models.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BC.API.Infrastructure.Configuration
{
    public class ProblemConfiguration : IEntityTypeConfiguration<Problem>
	{
		public void Configure(EntityTypeBuilder<Problem> builder)
		{
			builder.HasKey(x => x.Id);

			builder.HasOne(x => x.Bicycle)
				.WithMany(pm => pm.Problems)
				.HasForeignKey(pm => pm.BicycleId);

			builder.HasOne(x => x.Address)
				.WithMany(pm => pm.Problems)
				.HasForeignKey(pm => pm.AddressId);

			builder.Property(x => x.Place)
				.HasMaxLength(2048);

			builder.Property(x => x.Stage)
				.HasDefaultValue(ProblemStage.New);
		}
	}
}
