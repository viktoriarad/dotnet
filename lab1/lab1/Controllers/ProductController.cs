using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using lab1.Models;
using Microsoft.AspNetCore.Mvc;

namespace lab1.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult GetList()
        {
            var model = new List<ProductModel>
            {
                new ProductModel { Name = "Elephant", Description = "Elephants are mammals of the family Elephantidae and the largest existing land animals.", Price = "1.000.000 EUR" },
                new ProductModel { Name = "Monkey", Description = "Monkey is a common name that may refer to groups or species of mammals, in part, the simians of infraorder Simiiformes.", Price = "2.000 EUR" },
                new ProductModel { Name = "Tiger", Description = "The tiger (Panthera tigris) is the largest extant cat species and a member of the genus Panthera.", Price = "100.000 EUR" },
                new ProductModel { Name = "Kangaroo", Description = "The kangaroo is a marsupial from the family Macropodidae (macropods, meaning large foot). ", Price = "20.000 EUR" },
                new ProductModel { Name = "Cow", Description = "A house cow is a cow kept to provide milk for a home kitchen.", Price = "500 EUR" }
            };

            return View(model);
        }

    }
}
