namespace RubyNonlife.Infrastructure.Exceptions
{
    public partial class CustomExceptions
    {
        public class ForbiddenException : Exception
        {
            public ForbiddenException(string message) : base(message) { }
        }

    }
}
