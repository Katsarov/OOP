using System;

namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            Event ev = new Event();
            ev.
            
        }
    }

    class Event
    {
        private int privateField = 0;
        protected int protectedField = 0;
        internal int internalField = 0;
        public int publicField = 0;

        public class PrivateEvent
        {
           
        }

        public PrivateEvent PrivateEventInstance { get; set; }
    }
}
