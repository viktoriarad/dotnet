using lab1.Models;
using System.Collections.Generic;

namespace StoreProject.Models
{
    public interface IProductRepository
    {
        IEnumerable<ProductModel> GetItems();
    }
}