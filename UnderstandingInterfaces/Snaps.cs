using System;
using System.Collections;
using System.Collections.Generic;

namespace UnderstandingInterfaces
{
    public class Snaps : IEnumerable<Snap>
    {
        private readonly int NUMOFSNAPS = 25;

        private readonly Random _generator = new Random();

        private List<Snap> _deliveryPts = new List<Snap>();

        public Snaps()
        {
            for (int i = 0; i < NUMOFSNAPS; i++)
            {
                Snap snap = new Snap()
                {
                    SnapId = i + 1,
                    Lat = 36.0,
                    Lon = -76.0
                };

                _deliveryPts.Add(snap);
            }
        }


        public IEnumerator<Snap> GetEnumerator()
        {
            for (int i = 0; i < NUMOFSNAPS; i++)
            {
                yield return new Snap()
                {
                    SnapId = i + 1,
                    Lat = Math.Round(36 + _generator.NextDouble(), 4),
                    Lon = Math.Round((76 + _generator.NextDouble()) * -1, 4)
                };
            }

            //for (int i = 0; i < NUMOFSNAPS; i++)
            //{
            //    yield return _snaps[i];
            //}
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        // two problems with your API:
        // 1.  You are locked into using a List
        public List<Snap> GetListOfDeliveryPts()
        {
            return _deliveryPts;
        }

        // this is 
        public IEnumerable<Snap> GetDeliveryPts()
        {
            return _deliveryPts;
        }

    }
}