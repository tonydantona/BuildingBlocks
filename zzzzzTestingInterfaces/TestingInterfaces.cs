using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using CommonTypes;
using NUnit.Framework;
using NUnit.Framework.Constraints;
using UnderstandingInterfaces;

namespace zzzzzTestingInterfaces
{
    [TestFixture()]
    public class TestingInterfaces
    {
        [Test]
        // By returning IEnumerable we limit access
        // Even Reverse doesn't change the original order
        public void TestAccessIEnumerableOfSnaps()
        {
            Snaps snaps = new Snaps();

            foreach (var snap in snaps)
            {
                Console.WriteLine(snap);
            }

            var enumerable = snaps.Reverse();
        }

        [Test]
        public void TestAccessListOfDeliveryPts()
        {
            var snaps = new Snaps();

            var deliveryPts = snaps.GetListOfDeliveryPts();
            deliveryPts.RemoveRange(0, 10);

        }

        [Test]
        public void TestAccessOfIEnumerableDeliveryPts()
        {
            var snaps = new Snaps();

            var deliveryPts = snaps.GetDeliveryPts();

            var list = deliveryPts.Reverse();

        }

        [Test]
        public void TestIEnumerableWeatherData()
        {
            var warmDays2 = new WeatherDataStream("Ann Arbor").
                Where(item => item.Temperature > 80).
                Select(item => item);

            foreach (var data in warmDays2)
            {
                Console.WriteLine(data);
            }
        }

        [Test]
        public void TestPassingInterface()
        {
            MyCollection myCollection = new MyCollection();
            OutputServices.Print(myCollection);
        }

        [Test]
        public void TestEnumerableInterface()
        {
            Stops stops = new Stops();
            OutputServices.Print(stops);
        }

        [Test]
        public void TestConsoleOutputInterface()
        {
            IOutputBehavior consoleOutput = new ConsoleOutput();
            OutputServices.CreateOutput(consoleOutput);
        }

        [Test]
        public void TestWindowOutputInterface()
        {
            IOutputBehavior windowOutput = new WindowOutput();
            OutputServices.CreateOutput(windowOutput);
        }

        [Test]
        public void TestFileOutputInterface()
        {
            IOutputBehavior fileOutput = new FileOutput();
            OutputServices.CreateOutput(fileOutput);
        }

        

        [Test]
        public void TestIEquatableInterface()
        {
            Stop stop1 = new Stop {StopID = 1};

            Stop stop2 = new Stop {StopID = 1};

            bool isEqual = stop1.Equals(stop2);

            stop2.StopID = 2;

            isEqual = stop1.Equals(stop2);
        }

        [Test]
        public void TestIComparerInterface()
        {
            Stop stop1 = new Stop { StopID = 1 };
            Stop stop2 = new Stop { StopID = 2 };
            Stop stop3 = new Stop { StopID = 3 };

            List<Stop> stops = new List<Stop>(){stop3,stop2,stop1};

            stops.Sort();
        }


    }   
}