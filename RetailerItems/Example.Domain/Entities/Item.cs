using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Example.Domain.Model;

namespace Example.Domain.Entities
{
    public class Item : Entity
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Size { get; set; }
        [Required]
        public decimal Cost { get; set; }
        [Required]
        public bool InStock { get; set; }
        [Required]
        public string Colour { get; set; }

        public ICollection<RetailerItem> RetailerItems { get; set; }
    }
}