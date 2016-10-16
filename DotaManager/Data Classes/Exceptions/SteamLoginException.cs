using System;

namespace DotaManager.Data_Classes.Exceptions
{
    internal class SteamLoginException : Exception
    {
        public SteamLoginException()
        {

        }

        public SteamLoginException(string message) : base(message)
        {

        }
    }
}
