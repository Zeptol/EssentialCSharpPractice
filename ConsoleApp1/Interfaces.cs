using System;

namespace ConsoleApp1
{
    interface IReadableSettingsProvider
    {
        string GetSettings(string name, string defaultValue);
    }

    interface IWritableSettingsProvider
    {
        void SetSettings(string name, string value);
    }

    interface ISettingsProvider : IReadableSettingsProvider, IWritableSettingsProvider
    {

    }

    class FileSettingsProvider : ISettingsProvider
    {
        string IReadableSettingsProvider.GetSettings(string name, string defaultValue)
        {
            throw new NotImplementedException();
        }

        public void SetSettings(string name, string value)
        {
            throw new NotImplementedException();
        }
    }

}
