using Microsoft.EntityFrameworkCore;

namespace CrudContactosMVC.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {   
        }

        // Define your DbSet properties for your entities here
    }
}
