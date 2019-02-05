using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CarRent.Models
{
    public class Order: IEntity<int>
    {
        [Key]
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal TotalPrice { get; set; }
        
        public Worker Worker { get; set; }
        public Client Client { get; set; }
        public ICollection<Car> Cars { get; set; }
    }
}