using System;

namespace ToolBox.Domain.Exceptions
{
    public class InvalidLinkException : Exception
    {
        public InvalidLinkException(string link): base($"Link format is invalid : {link}") { }
    }
}