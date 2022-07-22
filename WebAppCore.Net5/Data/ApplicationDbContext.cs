using Microsoft.EntityFrameworkCore;
using WebAppCore.Net5.Models;
namespace WebAppCore.Net5.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {

        }

        public DbSet<Category> Category { get; set; }
    }
}
