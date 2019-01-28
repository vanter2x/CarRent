using System.Collections.Generic;

namespace CarRent.Models
{
    public class Client : Person
    {
        public string IdCard { get; set; }

        public virtual  ICollection<Order> Orders { get; set; }
    }
}