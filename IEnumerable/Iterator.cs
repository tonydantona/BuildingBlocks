using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerable
{
    public class Iterator
    {
        // Notice that even though we just return an int, the method signature shows a return of IEnumberable<int>.
        // The compiler is doing the work for us. The yield return instructs the compiler to create
        // a state engine in IL so we can create methods that retain their state w/o us having to write that code
        public static IEnumerable<int> YieldReturnOneTwoThree()
        {
            Console.WriteLine("Returning 1");
            yield return 1;

            Console.WriteLine("Returning 2");
            yield return 2;

            Console.WriteLine("Returning 3");
            yield return 3;
        }
    }
}
