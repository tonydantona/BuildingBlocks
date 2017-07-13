using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using IEnumerable;
using NUnit.Framework;

namespace zzzTestingIEnumerable
{
    [TestFixture]
    public class ExtensionMethodTests
    {
        /* Extension Methods */
        [Test]
        public void TestExtenstionMethods()
        {
            var clicks = ToClicks("10:00");
            //var clicks = "10:30".ToClicks();
            //Console.WriteLine(clicks);
        }

        public int ToClicks(string time)
        {
            // convert to clicks code here
            return 0;
        }

        [Test]
        public void TestOurEvenOnlyExtensionMethod()
        {
            int[] source = { 1, 3, 6, 9, 10 };

            var result = source.OnlyEven();
            
        }

        // btw, if we change the result of sequence do we alter the original sequence?
        [Test]
        public void TestDoesAlteringResultChangeOriginalSequence()
        {
            var stops = new Stops();

            var sorted = stops.OrderByDescending(s => s.StopID);

            var result = stops.Where(x => x.StopID % 2 == 0);

            foreach(var evenStop in result)
            {
                evenStop.StopID = 99;
            }

            foreach (var stop in stops)
            {
                Debug.WriteLine(stop);
            }

        }
    }
}
