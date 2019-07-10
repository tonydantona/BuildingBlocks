using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using CommonTypes;
using NUnit.Framework;
using UnderstandingIEnumerable;

namespace zzzTestingIEnumerable
{
    [TestFixture]
    public class ExtensionMethodTests
    {
        /* Extension Methods */
        [Test]
        public void TestExtenstionMethods()
        {
            //var clicks = ToClicks("10:30");
            var clicks = "10:30".ToClicks();
            Console.WriteLine(clicks);
        }

        public int ToClicks(string time)
        {
            // convert to clicks code here
            return 1050;
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

            // OrderBy does not alter the original list
            var sorted = stops.OrderByDescending(s => s.StopID);
            sorted.ElementAt(0).StopID = 88;

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
