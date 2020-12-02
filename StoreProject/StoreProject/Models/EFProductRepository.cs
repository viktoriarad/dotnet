using StoreProject.Models;
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

        public IQueryable<ProductModel> Products => ctx.Products;

        public void SaveProduct(ProductModel product)
        {
            if (product.Id == 0)
            {
                ctx.Products.Add(product);
            }
            else
            {
                ProductModel dbEntry = ctx.Products
                    .FirstOrDefault(p => p.Id == product.Id);
                if (dbEntry != null)
                {
                    dbEntry.Name = product.Name;
                    dbEntry.Description = product.Description;
                    dbEntry.Price = product.Price;
                    dbEntry.Category = product.Category;
                }
            }
            ctx.SaveChanges();
        }

        public ProductModel DeleteProduct(int Id)
        {
            ProductModel dbEntry = ctx.Products.FirstOrDefault(p => p.Id == Id);
            if (dbEntry != null)
            {
                ctx.Products.Remove(dbEntry);
                ctx.SaveChanges();
            }
            return dbEntry;
        }

    }
}
