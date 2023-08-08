using Microsoft.EntityFrameworkCore;

namespace Webprojekt.Data
{
    public class ToDoDbContext : DbContext
    {
        public ToDoDbContext(DbContextOptions<ToDoDbContext> options): base(options)
        {

        }
        private DbSet<ToDoModel> dbSet;

        public DbSet<ToDoModel> ToDoContext
        {
            get { return dbSet; }
            set { dbSet = value; }
        }

    }
}
