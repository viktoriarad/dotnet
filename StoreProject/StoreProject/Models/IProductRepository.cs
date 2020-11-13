using lab1.Models;
using System.Collections.Generic;
using System.Linq;

namespace StoreProject.Models
{
    public interface IProductRepository
    {
        IQueryable<ProductModel> Products { get; }
    }
}