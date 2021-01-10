using System;
using System.Collections.Generic;
using System.Text;

namespace ShadowingMembers
{
    public class TennisEvent : Event
    {
        public DateTime Duration { get; set; }

        public void Print()
        {
            this.Duration = DateTime.Now;  // това е пропъртито от настоящия клас TennisEvent
            base.Duration = 5;  // това е пропъртито от класа Event, което е от тип int
        }

        public void Start()
        {
            Console.WriteLine("Before start - preparation!");
            base.Start();
        }

        public override string ToString()
        {
            return $"Teniiiisss";
        }
    }
}
