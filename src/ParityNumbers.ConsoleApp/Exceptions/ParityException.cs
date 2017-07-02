using System;

namespace ParityNumbers.ConsoleApp.Exceptions
{
    public class ParityException : Exception
    {
        public ParityException()
        {
        }

        public ParityException(string msg)
            : base(msg)
        {
        }

        public ParityException(string msg, Exception inner)
            : base(msg, inner)
        {
        }
    }
}
