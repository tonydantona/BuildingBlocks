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
        // to get to linq we need extension methods - above (ToClicks) example, then simple one using sequence.
        // then maybe introduce delegates - simple -> anon -> lambda
        // then we summarize with writing our linq Where implementation
        // i would like to talk about interfaces, maybe an IEquatable or example or array sort example

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

    }
}