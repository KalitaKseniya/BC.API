using BC.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BC.API.Infrastructure.Configuration
{
    public class DeliveryOrderConfiguration : IEntityTypeConfiguration<DeliveryOrder>
	{
		public void Configure(EntityTypeBuilder<DeliveryOrder> builder)
		{
			builder.HasKey(x => x.Id);
			
			builder.HasOne(x => x.Provider)
				.WithMany(p => p.DeliveryOrders)
				.HasForeignKey(x => x.ProviderId);
			
			builder.HasMany(x => x.PartModels)
				.WithOne(pm => pm.DeliveryOrder)
				.HasForeignKey(x => x.DeliveryOrderId);			
			// ToDo K: add enum
		}
	}
}
