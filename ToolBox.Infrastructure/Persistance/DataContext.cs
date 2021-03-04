using Microsoft.EntityFrameworkCore;
using ToolBox.Domain.Entities;

namespace ToolBox.Infrastructure.Persistance
{
    public class DataContext: DbContext
    {
            public DbSet<Tool> Tools { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder options)
                => options.UseSqlServer(@"Data Source=LT-001\MSSQLSERVER01; Initial Catalog=ToolBoxDb; Integrated Security=true;");
    }
}