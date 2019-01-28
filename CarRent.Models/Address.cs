﻿using System.ComponentModel.DataAnnotations;

namespace CarRent.Models
{
    public class Address
    {
        [Key]
        public int Id { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Postcode { get; set; }
    }
}