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

			//Seeding(builder);
		}

		private void Seeding(EntityTypeBuilder<DeliveryOrderPartModels> builder)
		{
			//var part = new Part
			//{
			//	Id = new Guid("69ed5dd6-b375-4326-9223-58f6682b9c4d"),
			//	Name = "Part 1"
			//};
			//var manufacturer = new Manufacturer
			//{
			//	Id = new Guid("330d5501-f4b2-479c-b7d5-17c279153e39"),
			//	Name = "Manufacturer 1",
			//};
			
			//var partModel = new PartModel
			//{
			//	Id = new Guid("24438873-fad0-458b-8fd2-53bebf446976"),
			//	AvailableQuantity = 1,
			//	Name = "Part model 1",
			//	Manufacturer = manufacturer,
			//	Part = part,
			//	Price = 10
			//};


			//builder.HasData(
			//	new DeliveryOrderPartModels
			//	{
			//		Quantity = 1,
			//		PurchasePrice = 10,
			//		PartModel = partModel,
			//		DeliveryOrderId = new Guid("e0cd740a-7f17-4f2f-a627-91f930ad1e17"),
			//	}
			//);
		}
	}
}
