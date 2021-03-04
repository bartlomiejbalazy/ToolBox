using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using ToolBox.Domain.Exceptions;

namespace ToolBox.Domain.Entities
{
    public class Tool
    {
        private string _link;
        private string _name;
        private List<Tag> _tags;
        public int Id { get; init; }

        public Tool(string name, string link )
        {
            _tags = new List<Tag>();
            Name = name;
            Link = link;
        }

        public string Name
        {
            get => _name;
            set => _name = value ?? throw new ArgumentNullException();
        }

        public string Description { get; set; }

        public string Link
        {
            get => _link;
            set
            {
                if (!Regex.Match(value, "https?://.*..*").Success)
                    throw new InvalidLinkException(value);
                    
                _link = value;
            }
        }

        public List<Tag> Tags
        {
            get => _tags;
            set
            {
                ValidateTags(value);
                _tags = value;
            }
        }

        public void AddTags(params Tag[] tags)
        {
            ValidateTags(tags);
            _tags.AddRange(tags);
        }

        private static void ValidateTags(IEnumerable<Tag> tags)
        {
            if (tags == null || tags.Any(t => t == null))
                throw new ArgumentNullException();
        }
    }
}