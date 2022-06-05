using Microsoft.EntityFrameworkCore;

namespace Pull_data_from_Database_many_relation.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
             
        }

    }
}
