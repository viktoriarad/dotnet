using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using lab1.Models;
using Microsoft.AspNetCore.Mvc;
using StoreProject.Models;

namespace lab1.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository repository;

        public ProductController(IProductRepository repository)
        {
            this.repository = repository;
        }

        public IActionResult GetList()
        {
            return View(repository.GetItems());
        }

    }
}
