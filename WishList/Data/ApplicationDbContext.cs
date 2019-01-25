using Microsoft.EntityFrameworkCore;
using WishList.Models;

namespace WishList.Data
{
    class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Item> Items { get; set; }
    }
}