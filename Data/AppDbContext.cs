using Microsoft.EntityFrameworkCore;
using WebAPIwithJWT.Models;

namespace WebAPIwithJWT.Data
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options)
          : base(options)
        {

        }

        public DbSet<Department> departments { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
