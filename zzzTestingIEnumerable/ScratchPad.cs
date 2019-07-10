using System.Collections.Generic;
using NUnit.Framework;

namespace zzzTestingIEnumerable
{
    [TestFixture]
    public class ScratchPad
    {
        // interview questions
        [Test]
        public void CollectionQuestion()
        {
            var stops = new List<StopTest>();

            for (int i = 0; i < 10; i++)
            {
                var stop = new StopTest();
                stop.StopId = i;
                stops.Add(stop);
            }

            foreach (StopTest stop in stops)
            {
                stop.StopId = ++stop.StopId;
            }
        }
    }

    internal class StopTest
    {
        public int StopId { get; set; }
    }

}