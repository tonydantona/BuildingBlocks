using System;
using System.Collections;
using System.Runtime.InteropServices;
using CommonTypes;

namespace UnderstandingInterfaces
{
    public class OutputServices
    {
        // i'm using the concrete class that implemented this iterator to do the work
        public static void Print(IIterator collection)
        {
            while (collection.HasNext())
            {
                Console.WriteLine(collection.Next());
            }
        }

        // coding to an implementation
        //public static void Print(Stops stops)
        //{
        //    foreach (var stop in stops)
        //    {
        //        Console.WriteLine(stop);
        //    }
        //}

        // coding to an abstraction (interface)
        public static void Print(IEnumerable collection)
        {
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }

        public static void CreateOutput(IOutputBehavior output)
        {
            string text = "hello from IOutputBehavior";
            output.MakeOutput(text);
        }
    }
}