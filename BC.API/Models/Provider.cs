using System;
using System.ComponentModel.DataAnnotations;

namespace BC.API.Models
{
    public class Provider
    {
        public Guid Id { get; set; }

        [MaxLength(255)]
        public string Name { get; set; }

        [MaxLength(64)]
        public string Phone { get; set; }

        [MaxLength(255)]
        public string Email { get; set; }

        public ICollection<DeliveryOrder> DeliveryOrders { get; set; }
    }
}
