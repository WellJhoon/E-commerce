using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Data
{
    public class StorageContext : DbContext
    {
        public StorageContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}