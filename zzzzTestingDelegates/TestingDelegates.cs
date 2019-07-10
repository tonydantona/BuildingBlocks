using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using CommonTypes;
using NUnit.Framework;
using UnderstandingDelegates;

namespace zzzzTestingDelegates
{
    [TestFixture]
    [SuppressMessage("ReSharper", "SuggestVarOrType_Elsewhere")]
    public class TestingDelegates
    {
        // declare the delegate type
        public delegate void MessageProcessor(string s);
        [Test]
        public void TestDelegateUsingDelegateType()
        {
            Person person = new Person("TheBorg");

            // use the delegate type to declare a delegate
            MessageProcessor proc;

            // instantiate the delegate instance with our method
            proc = new MessageProcessor(person.Speak);

            // invoke the instance
            proc("Resistance is futile");
            proc.Invoke("You will be assimilated");
        }

        [Test]
        public void TestingDelegateUsingGenericDelegates()
        {
            // instantiate a object whose method we can assign to the delegate instance 
            Person person = new Person("Tony");

            // 1. Declare the delegate
            Func<string, int> myDelegate;

            // 2. Create the delegate instance
            myDelegate = person.TakesStringReturnInt;

            // 3. Invoke the delegate
            int result = myDelegate.Invoke("Hello");
            Console.WriteLine(myDelegate("hello"));
        }

        [Test]
        public void TestingAnonymousDelegates()
        {
            // 1. Declare the delegate
            Func<string, int> anonDelegate;

            // 2. Create the delegate instance
            anonDelegate = delegate (string s) { return s.Length; };

            // 3. Invoke the delegate
            Console.WriteLine(anonDelegate("hello"));
        }

        [Test]
        public void TestingSimpleLambda()
        {
            // 1. Declare the delegate
            Func<string, int> lambdaDelegate;

            // 2. Create the delegate instance
            lambdaDelegate = s => s.Length;

            // 3. Invoke the delegate
            Console.WriteLine(lambdaDelegate("hello world"));
        }

        [Test]
        public void TestSimpleLambdaWithIEnumerable()
        {
            Stops stops = new Stops();
            var result = stops.Where(x => x.StopID > 3);
        }

        [Test]
        public void TestPassingDelegate()
        {
            Action<int> currentDisplay = CurrentDisplay;
            DisplayMe(currentDisplay);
            //var delClass = new DelegatesAsParams();
            //delClass.DisplayMe(currentDisplay);
        }

        private void CurrentDisplay(int i)
        {
            Console.WriteLine(i);
        }

        private void DisplayMe(Action<int> displayer)
        {
            List<int> list = new List<int> { 1, 2, 3, 4, 5 };

            foreach (var item in list)
            {
                displayer(item);
            }
        }

        [Test]
        public void TestPassingDelegateUsingLambda()
        {
            //var delClass = new DelegatesAsParams();

            Func<int, bool> predicate = x => x > 3;
            //bool predicate(int x) => x > 3;

            var result = Filter(predicate);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        private IEnumerable<int> Filter(Func<int, bool> delegateFilter)
        {
            List<int> list = new List<int> { 1, 2, 3, 4, 5 };
            List<int> result = new List<int>();

            foreach (var item in list)
            {
                if (delegateFilter(item))
                {
                    result.Add(item);
                }
            }

            return result;
        }
    }
}