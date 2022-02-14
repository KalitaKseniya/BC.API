using BC.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BC.API.Infrastructure.Configuration
{
    public class AddressConfiguration : IEntityTypeConfiguration<Address>
	{
		public void Configure(EntityTypeBuilder<Address> builder)
		{
			builder.HasKey(x =>x.Id);

			builder.Property(m => m.AddressLine1)
				.HasMaxLength(1024)
				.IsRequired();

			builder.Property(m => m.AddressLine2)
				.HasMaxLength(1024);
		}
	}
}
