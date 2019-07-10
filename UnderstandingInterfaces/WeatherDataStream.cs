using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonTypes;

namespace UnderstandingInterfaces
{
    public class WeatherDataStream : IEnumerable<WeatherData>
    {
        private Random generator = new Random();
        public WeatherDataStream(string location)
        {
            // elided
        }
        private IEnumerator<WeatherData> getElements()
        {
            // Real implementation would read from
            // a weather station.
            for (int i = 0; i < 100; i++)
                yield return new WeatherData
                {
                    Temperature = generator.NextDouble() * 90,
                    WindSpeed = generator.Next(70),
                    WindDirection = (Immutables.Direction)generator.Next(7)
                };
        }
        #region IEnumerable<WeatherData> Members
        public IEnumerator<WeatherData> GetEnumerator()
        {
            return getElements();
        }
        #endregion

        #region IEnumerable Members
        System.Collections.IEnumerator
            System.Collections.IEnumerable.GetEnumerator()
        {
            return getElements();
        }
        #endregion
    }
}
