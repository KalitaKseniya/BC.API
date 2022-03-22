﻿using BC.API.Models.Enums;

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
        public ProblemStage Stage { get; set; }
        public string Description { get; set; }

        public Bicycle Bicycle { get; set; }
        public Address Address { get; set; }
        public ICollection<PartModelProblem> PartModelProblems { get; set; }
    }
}
