using System.Linq;
using System.Threading.Tasks;
using ToolBox.Domain.Entities;
using ToolBox.Infrastructure.Persistance;

namespace ToolBox.Infrastructure.Migrations
{
    public static class ApplicationDbContextSeed
    {
        public static async Task SeedTools(DataContext dbContext)
        {
            if(dbContext.Tools.Any())
                return;

            await dbContext.Tools.AddRangeAsync(new[]
            {
                new Tool("Resharper", "https://www.jetbrains.com/resharper/?gclid=Cj0KCQiA4feBBhC9ARIsABp_nbWaDQu0AAoEwdG6D6IQLzXqMGcRTB6x6JIqymZwNMALi68-QrqYK_MaAnPnEALw_wcB"),
                new Tool("Poly", "https://github.com/App-vNext/Polly"),
                new Tool("Mapster", "https://github.com/MapsterMapper/Mapster"),
            });

            await dbContext.SaveChangesAsync();
        }
    }
}