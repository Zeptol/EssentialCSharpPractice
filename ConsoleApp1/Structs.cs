using System;

namespace ConsoleApp1
{
    /**
     * Angle Struct
     *
     */
     struct Angle: ISettingsProvider,IAngle,IEquatable<Angle>
    {
        private readonly ISettingsProvider _settingsProviderImplementation;

        public Angle(int degrees, int minutes, int seconds, ISettingsProvider settingsProviderImplementation = default)
        {
            Degrees = degrees;
            Minutes = minutes;
            Seconds = seconds;
            _settingsProviderImplementation = settingsProviderImplementation;
        }

        public int Degrees { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }

        public void Move(int degrees, int minutes, int seconds)
        {
            Degrees = degrees;
            Minutes = minutes;
            Seconds = seconds;
        }

        public string GetSettings(string name, string defaultValue)
        {
            return _settingsProviderImplementation.GetSettings(name, defaultValue);
        }

        public void SetSettings(string name, string value)
        {
            _settingsProviderImplementation.SetSettings(name, value);
        }

        public static bool operator ==(Angle angle1, Angle angle2) => angle1.Equals(angle2);

        public static bool operator !=(Angle angle1, Angle angle2) => !(angle1 == angle2);

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public bool Equals(Angle other) => (Degrees, Minutes, Seconds) == (other.Degrees, other.Minutes, other.Seconds);
        public override int GetHashCode() => (Degrees, Minutes, Seconds).GetHashCode();

        public static bool operator true(Angle angle) => angle.Equals(default);

        public static bool operator false(Angle angle) => !angle.Equals(default);

        public static explicit operator double(Angle angle) => angle.Degrees;
        public static implicit operator Angle(double d) => new Angle((int) d, default, default);
    }

    class Coordinate:IDisposable
    {
        public Angle Longitude { get; set; }
        public Angle Latitude { get; set; }
        public static explicit operator double(Coordinate cord) => cord.Longitude.Degrees;

        ~Coordinate()
        {
            Dispose();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
        
    }

    interface IAngle
    {
        void Move(int degrees, int minutes, int seconds);
    }
}
