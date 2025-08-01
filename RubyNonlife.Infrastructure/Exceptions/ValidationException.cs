namespace RubyNonlife.Infrastructure.Exceptions
{
    public partial class CustomExceptions
    {
        public class ValidationException : Exception
        {
            public ValidationException(string message) : base(message) { }
        }

    }
}
