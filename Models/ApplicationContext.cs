using Microsoft.EntityFrameworkCore;
namespace DotnetBakery.Models
{   //                         this : means appcontext extends dbcontext
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) {}

        public DbSet<Baker> Bakers {get; set;}
    }
}