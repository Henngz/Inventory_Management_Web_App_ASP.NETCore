using Microsoft.EntityFrameworkCore;
using StoreCategoryWebApp.Models;

namespace StoreCategoryWebApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
    }    
}
