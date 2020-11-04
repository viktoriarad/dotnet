using lab1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreProject.Models
{
    public class ProductRepository : IProductRepository
    {
        public IEnumerable<ProductModel> GetItems()
        {
            return new List<ProductModel> {
                new ProductModel { Id = 1, Name = "Elephant", Description = "Elephants are mammals of the family Elephantidae and the largest existing land animals.", Price = "1.000.000 EUR" },
                new ProductModel { Id = 2, Name = "Monkey", Description = "Monkey is a common name that may refer to groups or species of mammals, in part, the simians of infraorder Simiiformes.", Price = "2.000 EUR" },
                new ProductModel { Id = 3, Name = "Tiger", Description = "The tiger (Panthera tigris) is the largest extant cat species and a member of the genus Panthera.", Price = "100.000 EUR" },
                new ProductModel { Id = 4, Name = "Kangaroo", Description = "The kangaroo is a marsupial from the family Macropodidae (macropods, meaning large foot). ", Price = "20.000 EUR" },
                new ProductModel { Id = 5, Name = "Cow", Description = "A house cow is a cow kept to provide milk for a home kitchen.", Price = "500 EUR" }
            };
        }
    }
}
