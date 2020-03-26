using System;

namespace Template.API.Infrastructure.Exceptions
{
    public class TemplateDomainException : Exception
    {
        public TemplateDomainException()
        { }

        public TemplateDomainException(string message)
            : base(message)
        { }

        public TemplateDomainException(string message, Exception innerException)
            : base(message, innerException)
        { }
    }
}
