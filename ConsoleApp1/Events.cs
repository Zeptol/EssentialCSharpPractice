using System;

namespace ConsoleApp1
{
    public class Thermostat
    {
        public class TemperatureArgs:EventArgs
        {
            public TemperatureArgs(float newTemperature)
            {
                NewTemperature = newTemperature;
            }

            public float NewTemperature { get; set; }
        }

        public float CurrentTemperature
        {
            get => _currentTemperature;
            set
            {
                _currentTemperature = value;
                _onTemperatureChange?.Invoke(this, new TemperatureArgs(value));
            }
        }

        private float _currentTemperature;
        event EventHandler<TemperatureArgs> OnTemperatureChange
        {
            add => _onTemperatureChange += value;
            remove => _onTemperatureChange -= value;
        }

        protected event EventHandler<TemperatureArgs> _onTemperatureChange;

        protected virtual void TemperatureChanged(TemperatureArgs e)
        {
            _onTemperatureChange?.Invoke(this, e);
        }
    }
}
