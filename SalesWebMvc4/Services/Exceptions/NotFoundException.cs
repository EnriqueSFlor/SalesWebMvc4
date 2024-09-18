using System;

namespace SalesWebMvc4.Services.Exceptions
{
    public class NotFoundException : ApplicationException
    {
        public NotFoundException(string message) : base(message) 
        {
        }
    }
}
