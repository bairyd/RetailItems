namespace Example.Domain.Entities
{
    public class RetailerLocation
    {
        public long RetailerId { get; set; }
        public Retailer Retailer { get; set; }

        public long LocationId { get; set; }
        public Location Location { get; set; }
    }
}