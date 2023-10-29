using api.Entities;
using Microsoft.EntityFrameworkCore;


namespace api.Data
{
    public class StorageContext : DbContext
    {
        public StorageContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Product> Producs { get; set; }
    }
}