using System.Collections.Generic;
using Example.Domain.Model;

namespace Example.Domain.Entities
{
    public class Retailer : Entity
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }
        public string WebsiteUrl { get; set; }
        public string TradingHours { get; set; }
        
        public ICollection<RetailerItem> RetailerItems { get; set; }
        
        public ICollection<RetailerLocation> RetailerLocations { get; set; }
    }
}