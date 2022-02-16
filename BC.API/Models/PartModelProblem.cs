namespace BC.API.Models
{
    public class PartModelProblem
    {
        public Guid Id { get; set; }
        public Guid PartId { get; set; }
        public Guid UserChosenPartId { get; set; }
        public Guid PartModelId { get; set; }
        public Guid ProblemId { get; set; }
        public int Amount { get; set; }
        public decimal PricePerDetail { get; set; }

        public Part Part { get; set; }
    }
}
