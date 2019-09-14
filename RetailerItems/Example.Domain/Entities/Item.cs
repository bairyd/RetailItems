using System.ComponentModel.DataAnnotations;
using Example.Domain.Model;

namespace Example.Domain.Entities
{
    public class Item : Entity
    {
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        [Required]
        [MaxLength(10)]
        public string Size { get; set; }
        [Required]
        public decimal Cost { get; set; }
        [Required]
        public bool InStock { get; set; }
        [Required]
        public string Colour { get; set; }
    }
}