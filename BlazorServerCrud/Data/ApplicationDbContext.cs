using BlazorServerCrud.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerCrud.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }
    }
}
