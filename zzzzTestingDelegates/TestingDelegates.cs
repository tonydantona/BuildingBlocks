using System;
using System.Linq;
using IEnumerable;
using NUnit.Framework;
using UnderstandingDelegates;

namespace zzzzTestingDelegates
{
    [TestFixture]
    public class TestingDelegates
    {
        // declare the delegate type
        public delegate void MessageProc(string s);
        [Test]
        public void TestDelegateUsingDelegateType()
        {
            Person tony = new Person("Tony");

            // use the delegate type to declare a delegate
            MessageProc proc;

            // instantiate the delegate instance with our method
            proc = new MessageProc(tony.Speak);

            // invoke the instance
            proc("hello");
            proc.Invoke("hello again");
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
            var delClass = new DelegatesAsParams();
            Action<int> currentDisplay = CurrentDisplay;
            delClass.DisplayMe(currentDisplay);
        }

        private void CurrentDisplay(int i)
        {
            Console.WriteLine(i);
        }

        [Test]
        public void TestPassingDelegateUsingLambda()
        {
            var delClass = new DelegatesAsParams();
            Func<int, bool> predicate = x => x > 3;

            var result = delClass.Filter(predicate);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}