using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StoreProject.Models;

namespace StoreProject.Controllers
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
            return View(repository.Products);
        }

        public ViewResult List(string category) => View(repository.Products.Where(p => p.Category == category));

        public IActionResult Index()
        {
            return View();
        }

    }
}
