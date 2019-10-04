using Microsoft.EntityFrameworkCore;
using zzzexception.Entities;

namespace zzzexception
{
    public class DataContext : DbContext
    {
        public DataContext() : base(new DbContextOptionsBuilder<DataContext>()
            .UseSqlServer("Data Source=localhost;Initial Catalog=test;User ID=sa;Password=Password666;Integrated Security=False", sqlServerOptions =>
            {
                sqlServerOptions.CommandTimeout(300);
                sqlServerOptions.EnableRetryOnFailure(3);
            })
            .EnableDetailedErrors()
            .Options)
        {
            
        }

        public DbSet<Test> Tests { get; set; }
    }
}