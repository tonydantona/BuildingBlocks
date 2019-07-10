using System;
using System.IO;

namespace UnderstandingInterfaces
{
    public class FileOutput : IOutputBehavior
    {
        public void MakeOutput(string text)
        {
            using (var writer = new StreamWriter(@"C:\Users\rti1ajd\Documents\Training Others\output.txt", false))
            {
                writer.WriteLine(text);
            }
        }
    }
}