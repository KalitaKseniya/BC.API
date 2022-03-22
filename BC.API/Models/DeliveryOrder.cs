using BC.API.Models.Enums;

namespace BC.API.Models
{
    public class DeliveryOrder
    {
        public Guid Id { get; set; }

        public Guid ProviderId { get; set; }
        
        public DateTime DateCreated { get; set; }

        public DateTime? DateFinished { get; set; }

        // ToDo K: make string witjh converter?
        //ToDo K: enum another with the same fields CHECK((Age >0 AND Age<100) AND (Email !='') AND (Phone !=''))
        public DeliveryOrderStage Stage { get; set; }
        
        public Provider Provider { get; set; }
        public ICollection<DeliveryOrderPartModels> PartModels { get; set; }//should be configured??
    }
}
