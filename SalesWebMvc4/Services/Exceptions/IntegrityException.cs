using System;

namespace SalesWebMvc4.Services.Exceptions
{
    public class IntegrityException : ApplicationException
    {
        public IntegrityException(string message) : base (message)
        {
        }
    }
}
