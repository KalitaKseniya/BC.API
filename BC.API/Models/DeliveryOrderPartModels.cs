namespace BC.API.Models
{
    public class DeliveryOrderPartModels
    {
        public Guid PartModelId { get; set; }
        public Guid DeliveryOrderId { get; set; }
        public int Quantity { get; set; }
        public decimal PurchasePrice { get; set; }

        public DeliveryOrder DeliveryOrder { get; set; }
    }
}
