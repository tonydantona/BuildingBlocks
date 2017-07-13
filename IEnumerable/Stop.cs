using System;

namespace IEnumerable
{
    public class Stop : IEquatable<Stop>
    {
        public int StopID { get; set; }

        public bool Equals(Stop other)
        {
            // check whether the compared object is null
            if (Object.ReferenceEquals(other, null))
                return false;

            // check whether the compared object references the same object
            if(Object.ReferenceEquals(this,other))
                return true;

            // ok, now check if the properties are equal
            return this.StopID.Equals(other.StopID);
        }

        // We should override GetHashCode() here too since
        // if Equals() returns true for a pair of objects then
        // GetHashCode() must return the same value for these objects
        public override int GetHashCode()
        {
            //Get hash code for the StopID field since that's our basis for comparison.
            return StopID.GetHashCode();
        }

        public override string ToString()
        {
            return string.Format("I am stop number {0}", StopID);
        }
    }
}