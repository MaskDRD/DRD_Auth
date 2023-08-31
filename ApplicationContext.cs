using auth.Model;
using Microsoft.EntityFrameworkCore;

namespace auth
{
    public class ApplicationContext : DbContext
    {
        public DbSet<UserModel> userModel { get; set; } = null!;
        
        public ApplicationContext(DbContextOptions<ApplicationContext> options): base(options) { }
    }
}
