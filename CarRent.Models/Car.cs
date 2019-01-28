using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;

namespace CarRent.Models
{
    public class Car
    {
        [Key]
        public int Id { get; set; }
        
    }
}