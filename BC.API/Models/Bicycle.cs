namespace BC.API.Models
{
    public class Bicycle
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }//ToDo K: add FK to user
        public string Model { get; set; }
        public string SerailNumber { get; set; }
    }
}
