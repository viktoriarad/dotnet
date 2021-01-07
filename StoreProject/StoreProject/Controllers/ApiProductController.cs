using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StoreProject.Models;

namespace StoreProject.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class ApiProductController : ControllerBase
    {
        private readonly IProductRepository repository;
        
        public ApiProductController(IProductRepository repository)
            {
                this.repository = repository;
            }

        [HttpGet]
        public IEnumerable<ProductModel> Get() => repository.Products;

        [HttpGet("{Id}")]
        public ProductModel Get(int Id) => repository[Id];

        [HttpPost]
        public ProductModel Post([FromBody] ProductModel res) =>
            repository.AddProduct(new ProductModel
            {
                Name = res.Name,
                Description = res.Description,
                Price = res.Price,
                Category = res.Category
            });

        [HttpPut]
        public bool Put([FromBody] ProductModel res) =>
            repository.UpdateProduct(new ProductModel
            {
                Id = res.Id,
                Name = res.Name,
                Description = res.Description,
                Price = res.Price,
                Category = res.Category
            });

        [HttpDelete("{id}")]
        public void Delete(int id) => repository.DeleteProduct(id);
    }
}

