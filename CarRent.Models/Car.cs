using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;

namespace CarRent.Models
{
    public class Car : IEntity<int>
    {
        [Key]
        public int Id { get; set; }
        public string Model { get; set; }
        public DateTime ProductionDate { get; set; }
        public string Color { get; set; }
        public int NumberOfDoors { get; set; }
            
        public virtual Order Order { get; set; }
    }
}