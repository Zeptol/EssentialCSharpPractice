using System;
using System.Runtime.Serialization;

namespace ConsoleApp1
{
    [Serializable]
    class DatabaseException:Exception
    {
        public DatabaseException(SerializationInfo serializationInfo, StreamingContext context)
        {

        }
    }
}
