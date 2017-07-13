using System;
using IEnumerable;
using NUnit.Framework;

namespace zzzTestingIEnumerable
{
    [TestFixture]
    public class YieldReturnTests
    {
        // As you can see each time we reach the yield return statement
        // control is returned back to the caller method.
        [Test]
        public void TestingYieldReturn()
        {
            foreach (var number in Iterator.YieldReturnOneTwoThree())
            {
                Console.WriteLine(number);
            }
        }

        // Testing our own IEnumerable
        [Test]
        public void TestingOurOwnIEnumerable()
        {
            var stops = new Stops();

            
            foreach(var stop in stops)
            {
                Console.WriteLine(stop);
            }
        }
    }
}