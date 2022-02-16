using BC.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BC.API.Infrastructure.Configuration
{
    public class DeliveryOrderPartModelsConfiguration : IEntityTypeConfiguration<DeliveryOrderPartModels>
	{
		public void Configure(EntityTypeBuilder<DeliveryOrderPartModels> builder)
		{
			builder.HasKey(x => new {x.DeliveryOrderId, x.PartModelId});

			//builder.HasOne(x => x.DeliveryOrder)
			//	.WithMany(p => p.DeliveryOrders)
			//	.HasForeignKey(x => x.ProviderId);

			//builder.Has(x => x.PartModel)
			//	.WithOne(pm => pm.DeliveryOrder)
			//	.HasForeignKey(x => x.DeliveryOrderId);
			//// ToDo K: add enum
		}
	}
}
