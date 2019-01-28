using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarRent.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal TotalPrice { get; set; }

        [ForeignKey("Client")]  
        public int Client_Id { get; set; }

        [ForeignKey("Worker")]
        public int Worker_Id { get; set; }

        public virtual Worker Worker { get; set; }
        public virtual Client Client { get; set; }
        public virtual ICollection<Car> Cars { get; set; }

    }
}