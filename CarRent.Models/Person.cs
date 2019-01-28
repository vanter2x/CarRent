using System.ComponentModel.DataAnnotations;

namespace CarRent.Models
{
    public abstract class Person : IEntity<int>
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public Address Address { get; set; }
        public string Phone { get; set; }
    }
}