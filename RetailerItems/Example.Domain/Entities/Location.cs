using System.Collections.Generic;
using Example.Domain.Model;

namespace Example.Domain.Entities
{
    public class Location : Entity
    {
        public string Name { get; set; }
        
        public ICollection<RetailerLocation> RetailerLocations { get; set; }
    }
}