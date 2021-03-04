using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ToolBox.Application.Models;
using ToolBox.Application.Services;

namespace ToolBoxApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ToolsController : ControllerBase
    {
        private readonly ILogger<ToolsController> _logger;
        private readonly IToolService _toolService;

        public ToolsController(ILogger<ToolsController> logger, IToolService toolService)
        {
            _logger = logger;
            _toolService = toolService;
        }

        [HttpGet]
        public async Task<IEnumerable<ToolModel>> Get()
        {
            var rng = new Random();

            return await _toolService.GetAllTools();
            
            // return Enumerable.Range(1, 5).Select(index => new ToolModel
            //     {
            //         Id = index,
            //         Name = $"Name{index}",
            //         Description = $"Some Description{index}",
            //         Link = $"Some Url{index}",
            //         Tags = new []{new TagModel()
            //         {
            //             Id = index,
            //             Name = "Important tool"
            //         }}
            //     })
            //     .ToArray();
        }
    }
}