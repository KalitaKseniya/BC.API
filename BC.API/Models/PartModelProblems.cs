using System;
using System.Collections.Generic;
using System.Text;

namespace BC.API.Models
{
    public class PartModelProblems
    {
        public Guid Id { get; set; }
        public Guid UserChosenPartId { get; set; }
        public Guid PartModelId { get; set; }
        public Guid ProblemId { get; set; }
        public int Amount { get; set; }
        public decimal PricePerDetail { get; set; }
    }
}
