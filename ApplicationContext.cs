using Microsoft.EntityFrameworkCore;

namespace auth
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext() {}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string defaultConnection = "server=localhost;port=3306;database=bd;uid=root;password=1;";
            MySqlServerVersion serverVersion = new MySqlServerVersion(new Version(5, 0, 29));
            optionsBuilder.UseMySql(defaultConnection, serverVersion);
        }
    }
}
