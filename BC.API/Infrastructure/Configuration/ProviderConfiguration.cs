using BC.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BC.API.Infrastructure.Configuration
{
    public class ProviderConfiguration : IEntityTypeConfiguration<Provider>
	{
		public void Configure(EntityTypeBuilder<Provider> builder)
		{
			builder.HasKey(x => x.Id);

			builder.Property(m => m.Name)
				.HasMaxLength(255)
				.IsRequired();
			builder.Property(m => m.Phone)
				.HasMaxLength(64)
				.IsRequired();
			builder.Property(m => m.Email)
				.HasMaxLength(255)
				.IsRequired();

			builder.HasMany(x => x.DeliveryOrders)
				.WithOne(pm => pm.Provider)
				.HasForeignKey(pm => pm.ProviderId);
		}
	}
}
