namespace RubyNonlife.Infrastructure.Exceptions
{
    public partial class CustomExceptions
    {
        public class UnauthorizedException : Exception
        {
            public UnauthorizedException(string message) : base(message) { }
        }

    }
}
