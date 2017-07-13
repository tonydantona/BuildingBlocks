using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerable
{
    public static class ExtensionMethods
    {
        public static int ToClicks(this string time)
        {
            try
            {
                // Let's just pad the time (if needed) to make life easier
                if (4 == time.Length) // remember we have to count the colon
                {
                    // then it's a single digit hour
                    time = "0" + time;
                }
                //See if theres anything before or after :, if not, append with 00

                if (time.EndsWith(":"))
                {
                    time += "00";
                }
                if (time.StartsWith(":"))
                {
                    time = "00" + time;
                }


                double dMins = Convert.ToDouble(time.Substring(3, 2)) / 60 * 100;
                int iHrs = Convert.ToInt32(time.Substring(0, 2)) * 100;

                return Convert.ToInt32(Math.Ceiling(iHrs + dMins));
            }
            catch (Exception)
            {
                throw new Exception("Error in ToClicks");
            }

        }

        //public static IEnumerable<TSource> Where<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
        public static IEnumerable<int> OnlyEven (this IEnumerable<int> source)
        {
            List<int> result = new List<int>();

            foreach(var value in source)
            {
                if (value % 2 == 0)
                {
                    result.Add(value);
                }
            }

            return result;
        }

    }
}
