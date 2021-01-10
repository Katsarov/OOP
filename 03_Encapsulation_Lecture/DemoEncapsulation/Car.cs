using System;
using System.Collections.Generic;
using System.Text;

namespace DemoEncapsulation
{
    class Car
    {
        public Engine Engine { get; set; }

        public SpeedStats SpeedStats { get; set; }

        public Tyres Tyres { get; set; }

        public void Start()
        {
            Engine.Start();
            SpeedStats.StartWatching();
            if (Tyres.IsRubbish())
            {
                // Ако имаме клас Stats  , мовем да кажем: Stats.Show("Change tyres!");
            }

            // По същия наюин мовем да прошерим и за Oil.Level
        }

        public void Stop()
        {
            Engine.Stop();
            SpeedStats.StartWatching();
            if (Tyres.IsRubbish())
            {
                // Ако имаме клас Stats  , мовем да кажем: Stats.Show("Change tyres!");
            }
        }

        public void PressPedal(long amount)
        {

        }
    }
}
