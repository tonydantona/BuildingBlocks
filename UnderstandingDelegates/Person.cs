using System;

namespace UnderstandingDelegates
{
    public class Person
    {
        public string Name { get; set; }

        public Person(string name)
        {
            Name = name;
        }

        public void Speak(string message)
        {
            Console.WriteLine("{0} says {1}", Name, message);
        }

        public int TakesStringReturnInt(string s)
        {
            return s.Length;
        }
    }
}