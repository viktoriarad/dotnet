using StoreProject.Models;
using System.Collections.Generic;
using System.Linq;

namespace StoreProject.Models
{
    public interface IProductRepository
    {
        IQueryable<ProductModel> Products { get; }

        void SaveProduct(ProductModel product);

        ProductModel DeleteProduct(int Id);
    }
}