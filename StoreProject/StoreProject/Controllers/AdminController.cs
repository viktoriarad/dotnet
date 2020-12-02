using System;
using System.Globalization;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StoreProject.Models;

namespace StoreProject.Controllers
{
    public class AdminController : Controller
    {
        private readonly IProductRepository repository;

        public AdminController(IProductRepository repository)
        {
            this.repository = repository;
        }
        public ViewResult Index()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en-US");

            return View(repository.Products);
        }

        [HttpGet]
        public ViewResult Edit(int id)
        {
            var productToEdit = repository.Products.FirstOrDefault(p => p.Id == id);
            return View(productToEdit);

        }

        [HttpPost]
        public IActionResult Save(ProductModel product)
        {
            if (ModelState.IsValid)
            {
                repository.SaveProduct(product);
                TempData["message"] = $"{product.Name} saved";
                return RedirectToAction("Index");
            }
            else
            {
              return View("Edit", product);
            }
        }     
        public ViewResult Create() => View("Edit", new ProductModel());

        [HttpPost]
        public IActionResult Delete(int id)
        {
            ProductModel deleteProduct = repository.DeleteProduct(id);
            if(deleteProduct != null)
            {
                TempData["message"] = $"{deleteProduct.Name} deleted";
            }
            return RedirectToAction("Index");
        }

    }
        
}
