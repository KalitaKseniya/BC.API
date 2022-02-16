namespace BC.API.Models
{
    public class Part
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public ICollection<PartModel> PartModels { get; set; }
        public ICollection<PartModelProblem> PartModelProblems { get; set; }
    }
}
