using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using CommonTypes;
using NUnit.Framework;
using UnderstandingIEnumerable;

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

            var results = stops.Where( x => x.StopID > 3);
        }

        // simple example of using IEnumerable
        [Test]
        public void IEnumerableExample()
        {
            IEnumerable<int> source = new[] {1, 2, 3, 4, 5};
            var result = source.Where(x => x > 2);

            foreach (var i in result)
            {
                Console.WriteLine(i);
            }
        }

        public void TestInterface()
        {
            List<string> list = new List<string>();
            // list.
            
            IEnumerable<string> ienum = new List<string>();
            // ienum.
        }

        [Test]
        public void TestingSequences()
        {
            Employee p1 = new Employee() {Id = 1};
            Employee p2 = new Employee() {Id = 1};

            // Equals will return true for two objects that reference the same objects.     
            Console.WriteLine("p1 equals p1 -> {0}",p1.Equals(p1));

            // It will not return true if the objects have the same values
            // but have different references (are differenct objects)
            Console.WriteLine("p1 equals p2 -> {0}", p1.Equals(p2));

            Console.WriteLine();

            var listOneP1 = new List<Employee> { p1 };
            var listTwoP1 = new List<Employee> { p1 };
            // SequenceEqual will return true for two sequences that reference the same objects.
            // (There is only one instance of p1)
            Console.WriteLine("listOneP1 equals listTwoP1 -> {0}", listOneP1.SequenceEqual(listTwoP1));


            var listThreeP2 = new List<Employee> {p2};
            // It will not return true if the objects have the same values but have different references
            Console.WriteLine("listOneP1 equals listThreeP2 -> {0}", listOneP1.SequenceEqual(listThreeP2));


            Console.WriteLine();
            // unless... you implement IEquatable<T> and specify which properties to compare
            Stop stop1 = new Stop {StopID = 1};

            Stop stop2 = new Stop {StopID = 1};

            var listOneStop1 = new List<Stop> {stop1};
            var listTwoStop2 = new List<Stop> {stop2};
            Console.WriteLine("listOneStop1 equals listTwoStop2 -> {0}", listOneStop1.SequenceEqual(listTwoStop2));

            Console.WriteLine();
            // fyi, constructor populates collection with some stops
            var stops1 = new Stops();     
            var stops2 = new Stops();
            // this will be true because Stop implements IEquatable<T>
            Console.WriteLine("stops1 equals stops2 -> {0}", stops1.SequenceEqual(stops2));

            Console.WriteLine();

            //var s1 = "tony";
            //var s2 = "tony";

            //Console.WriteLine("s1 equals s2 -> {0}", s1.Equals(s2));
        }

        [Test]
        public void IEnumerableAsReturnValue()
        {
            // fyi, constructor populates collection with some stops
            Stops stops = new Stops();

            // linq returns IEnumerable
            IEnumerable<Stop> results = stops.Where(s => s.StopID > 2);

            // verify that the IEnumerable results IS a reference to stops
            foreach (var result in results)
            {
                result.StopID = 100;
            }

            foreach (var stop in stops)
            {
                Console.WriteLine(stop);
            }

            // unless .ToList() is used
            Stops stops2 = new Stops();
            IEnumerable<Stop> results2 = stops.Where(s => s.StopID > 2).ToList();

        }



    }
}