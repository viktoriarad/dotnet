using lab1.Controllers;
using lab1.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace StoreProject.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<ProductModel> Products { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
    }
}
