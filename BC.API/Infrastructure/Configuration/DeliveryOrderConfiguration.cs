using BC.API.Models;
using BC.API.Models.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.ObjectModel;

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
			
			builder.HasMany(x => x.DeliveryOrderPartModels)
				.WithOne(pm => pm.DeliveryOrder)
				.HasForeignKey(x => x.DeliveryOrderId);
			
			builder.Property(x => x.Stage)
				.HasConversion(
					v => v.ToString(),
					v => (DeliveryOrderStage)Enum.Parse(typeof(DeliveryOrderStage), v));
		
			Seeding(builder);
		}

		private void Seeding(EntityTypeBuilder<DeliveryOrder> builder)
        {
			builder.HasData(
				new DeliveryOrder
				{
					Id = new Guid("e0cd740a-7f17-4f2f-a627-91f930ad1e17"),
					DateCreated = DateTime.Now,
					DateFinished = null,
					Stage = DeliveryOrderStage.New,
					ProviderId = new Guid("2c05de27-bb62-4149-a55f-728a9dacb701")
				}
			) ;
        }
	}
}
