using lab1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreProject.Models
{
    public class EFProductRepository : IProductRepository
    {
        private readonly AppDbContext ctx;

        public EFProductRepository(AppDbContext ctx)
        {
            this.ctx = ctx;
        }

        public IEnumerable<ProductModel> GetItems() => ctx.Products;

    }
}
