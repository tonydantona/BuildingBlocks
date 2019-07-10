using System;

namespace UnderstandingInterfaces
{
    public class ConsoleOutput : IOutputBehavior
    {
        public void MakeOutput(string text)
        {
            Console.WriteLine(text);
        }
    }
}