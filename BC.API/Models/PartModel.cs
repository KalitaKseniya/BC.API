using System;

namespace BC.API.Models
{
    public class PartModel
    {
        public Guid Id { get; set; }
        public Guid PartId { get; set; }
        public string Name { get; set; }
        public int AvailableQuantity { get; set; }
        public decimal Price { get; set; }//ToDo K: .HasPrecision(15, 2)
        public Guid ManufacturerId { get; set; }
    }
}
