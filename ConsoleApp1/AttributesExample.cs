using System;
using System.Runtime.Serialization;

namespace ConsoleApp1
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = true)]
    public class CommandLineSwitchAliasAttribute : Attribute
    {
        public CommandLineSwitchAliasAttribute(string alias)
        {
            Alias = alias;
        }

        public string Alias { get; }
    }
    [Serializable]
    public class EncryptableDocument : ISerializable {
        enum Field
        {
            Title,Data
        }

        public string Title { get; set; }
        public string Data { get; set; }

        public static string Encrypt(string data)
        {
            var encryptedData = data;
            return encryptedData;
        }

        public static string Decrypt(string encryptedData)
        {
            var data = encryptedData;
            return data;
        }
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue(Field.Title.ToString(), Title);
            info.AddValue(Field.Data.ToString(), Encrypt(Data));
        }

        public EncryptableDocument(SerializationInfo info, StreamingContext context)
        {
            Title = info.GetString(Field.Title.ToString());
            Data = Decrypt(info.GetString(Field.Data.ToString()));
        }
    }
}
