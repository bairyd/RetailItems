namespace Example.Domain.Entities
{
    public class RetailerItem
    {
        public long RetailerId { get; set; }
        public Retailer Retailer { get; set; }

        public long ItemId { get; set; }
        public Item Item { get; set; }
    }
}