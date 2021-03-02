using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ToolBoxApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ToolsController : ControllerBase
    {
        private readonly ILogger<ToolsController> _logger;

        public ToolsController(ILogger<ToolsController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<ToolModel> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new ToolModel
                {
                    Id = index,
                    Name = $"Name{index}",
                    Description = $"Some Description{index}",
                    Link = $"Some Url{index}",
                    Tags = new []{new TagModel()
                    {
                        Id = index,
                        Name = "Important tool"
                    }}
                })
                .ToArray();
        }
    }
}