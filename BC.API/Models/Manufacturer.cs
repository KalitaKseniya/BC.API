using System;

namespace BC.API.Models
{
    public class Manufacturer
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public ICollection<DeliveryOrder> DeliveryOrders { get; set; }
    }
}
