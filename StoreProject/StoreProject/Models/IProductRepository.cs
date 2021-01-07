using StoreProject.Models;
using System.Collections.Generic;
using System.Linq;

namespace StoreProject.Models
{
    public interface IProductRepository
    {
        IQueryable<ProductModel> Products { get; }

        ProductModel this[int id] { get; }

        void SaveProduct(ProductModel product);
        ProductModel AddProduct(ProductModel product);
        bool UpdateProduct(ProductModel product);

        ProductModel DeleteProduct(int Id);


    }
}