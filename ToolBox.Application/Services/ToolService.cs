using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ToolBox.Application.Models;
using ToolBox.Infrastructure.Persistance;

namespace ToolBox.Application.Services
{
    public class ToolService : IToolService
    {
        private readonly DataContext _dataContext;

        public ToolService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public async Task<IEnumerable<ToolModel>> GetAllTools()
        {
            var listAsync = await _dataContext.Tools.ToListAsync();
            
            //TODO: Add Mapping latter
            return listAsync.Select(x=>new ToolModel()
            {
                Id = x.Id,
                Description = x.Description,
                Link = x.Link,
                Name = x.Name,
                Tags = x.Tags.Select(t=>new TagModel{Id = t.Id, Name = t.Name})
            });
        }
    }
}