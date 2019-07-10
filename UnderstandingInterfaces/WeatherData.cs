using System;
using CommonTypes;

namespace UnderstandingInterfaces
{
    public class WeatherData
    {
        public double Temperature { get; set; }

        public int WindSpeed { get; set; }

        public Immutables.Direction WindDirection { get; set; }

        public override string ToString()
        {
            return string.Format("Temperature = {0}, Wind is {1} mph from the {2}", Temperature, WindSpeed, WindDirection);
        }
    }
}