using System;
using System.Runtime.Serialization;

namespace Golf_Game
{
    [Serializable]
    internal class AngleInvalidExeption : Exception
    {
        public AngleInvalidExeption()
        {
        }

        public AngleInvalidExeption(string message) : base(message)
        {
        }

        public AngleInvalidExeption(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected AngleInvalidExeption(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}