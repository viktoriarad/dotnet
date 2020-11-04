using System;
using System.ComponentModel.DataAnnotations;

namespace lab1.Models
{
    public class ProductModel
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Price { get; set; }
    }
}
