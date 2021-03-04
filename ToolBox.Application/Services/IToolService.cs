using System.Collections.Generic;
using System.Threading.Tasks;
using ToolBox.Application.Models;

namespace ToolBox.Application.Services
{
    public interface IToolService
    {
        Task<IEnumerable<ToolModel>> GetAllTools();
    }
}