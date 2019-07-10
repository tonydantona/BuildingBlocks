using System.Collections;
using System.Collections.Generic;

namespace CommonTypes
{
    public class Stops : IEnumerable<Stop>
    {
        private readonly Stop[] _stops;

        private const int ArraySize = 5;

        public Stops()
        {
            _stops = new Stop[ArraySize];

            for (int i = 0; i < ArraySize; i++)
            {
                _stops[i] = new Stop {StopID = i + 1};
            }
        }
       
        public IEnumerator<Stop> GetEnumerator()
        {
            for (int i = 0; i < ArraySize; i++)
            {
                yield return _stops[i];
            }
        }


        IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void OptimizeStops()
        {
            for (int i = 0; i < ArraySize; i++)
            {
                _stops[i].ODO = i;
            }
        }
    }
}