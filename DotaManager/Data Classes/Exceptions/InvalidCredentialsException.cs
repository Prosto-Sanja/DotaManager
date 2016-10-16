using System;

namespace DotaManager.Data_Classes.Exceptions
{
    internal class InvalidCredentialsException : Exception
    {
        public InvalidCredentialsException()
        {
            
        }

        public InvalidCredentialsException(string message) : base(message)
        {
            
        }
    }
}
