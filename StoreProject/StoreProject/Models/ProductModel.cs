using System;
using System.ComponentModel.DataAnnotations;

namespace StoreProject.Models
{
    public class ProductModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter a product name")]
        [Display(Name = "Name")]     
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter a description")]
        [Display(Name = "Description")]
        public string Description { get; set; }

        [Required]
        [Range(0.01, double.MaxValue,
            ErrorMessage = "Please enter a valid price")]
        [Display(Name = "Price")]
        public int Price { get; set; }

        [Required(ErrorMessage = "Please specify a category")]
        [Display(Name = "Category")]
        public string Category { get; set; }
    }
}
