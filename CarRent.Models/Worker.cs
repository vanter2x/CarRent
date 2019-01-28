using System.Collections.Generic;

namespace CarRent.Models
{
    public class Worker : Person
    {
        public AccountType AccountType { get; set; }

        public virtual ICollection<Order> Order { get; set; }
    }
}