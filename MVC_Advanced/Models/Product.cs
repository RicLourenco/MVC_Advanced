﻿namespace MVC_Advanced.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public DateTime LastPurchase { get; set; }
        public float Stock { get; set; }
        public string Remarks { get; set; }
    }
}