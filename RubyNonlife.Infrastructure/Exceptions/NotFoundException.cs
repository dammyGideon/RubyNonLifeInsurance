namespace RubyNonlife.Infrastructure.Exceptions
{
    public partial class CustomExceptions
    {
        public class NotFoundException : Exception
        {
            public NotFoundException(string message) : base(message) { }
        }

    }
}
