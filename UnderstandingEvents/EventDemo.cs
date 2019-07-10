using System;

namespace UnderstandingEvents
{
    public class EventDemo
    {
        public event Action<string> IAmTheEvent;

        public void RaiseTheEvent()
        {
            if (IAmTheEvent != null)
            {
                IAmTheEvent("I have been raised");
            }
        }
    }
}