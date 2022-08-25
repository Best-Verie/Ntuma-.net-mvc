using Microsoft.EntityFrameworkCore;
using Ntuma.Models;

namespace Ntuma.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options)
        {

        }

        public DbSet<Category> categories { get; set; }

    }
}
