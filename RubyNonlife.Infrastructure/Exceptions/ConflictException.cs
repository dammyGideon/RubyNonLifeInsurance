namespace RubyNonlife.Infrastructure.Exceptions
{
    public partial class CustomExceptions
    {
        public class ConflictException : Exception
        {
            public ConflictException(string message) : base(message) { }
        }

    }
}
