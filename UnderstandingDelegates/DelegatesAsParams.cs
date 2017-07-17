using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace UnderstandingDelegates
{
    public class DelegatesAsParams
    {
        public IEnumerable<int> Filter(Func<int,bool> delegateFilter)
        {
            List<int> list = new List<int> {1, 2, 3, 4, 5};
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

        public void DisplayMe(Action<int> displayer)
        {
            List<int> list = new List<int> { 1, 2, 3, 4, 5 };

            foreach (var item in list)
            {
                displayer(item);
            }
        }
       
    }
}   