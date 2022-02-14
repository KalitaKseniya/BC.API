using System;

namespace BC.API.Models
{
    public class Problem
    {
        public Guid Id { get; set; }
        public Guid BicycleId { get; set; }
        public Guid AddressId { get; set; }
        public string Place { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateFinished { get; set; }
        public Stage Stage { get; set; }
        public string Description { get; set; }
    }
}
