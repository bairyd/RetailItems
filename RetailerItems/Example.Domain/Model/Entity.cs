using System.ComponentModel.DataAnnotations;

namespace Example.Domain.Model
{
    public class Entity
    {
        [Key]
        public int Id { get; set; }
    }
}