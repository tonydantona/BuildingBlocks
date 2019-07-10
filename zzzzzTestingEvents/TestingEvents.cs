using System;
using NUnit.Framework;
using NUnit.Framework.Internal;
using UnderstandingEvents;

namespace zzzzzTestingEvents
{
    [TestFixture]
    public class TestingEvents
    {
        [Test]
        public void TestGuiEvent()
        {
            MyGui myGui = new MyGui();
            myGui.Button.GenerateEvent();
        }


        [Test]  
        public void TestEvent()
        {
            EventDemo eventDemo = new EventDemo();

            eventDemo.IAmTheEvent += eventDemoHandler;

            eventDemo.RaiseTheEvent();

        }

        private void eventDemoHandler(string obj)
        {
            Console.WriteLine(obj);
        }

    }
}