using System;

namespace DotaManager.Data_Classes.Exceptions
{
    internal class ConnectionException : Exception
    {
        public ConnectionException()
        {

        }

        public ConnectionException(string message) : base(message)
        {

        }
    }
}
