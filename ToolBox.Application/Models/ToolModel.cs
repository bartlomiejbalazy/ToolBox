using System.Collections.Generic;

namespace ToolBox.Application.Models
{
    public class ToolModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Link { get; set; }
        public IEnumerable<TagModel> Tags { get; set; }
    }
}