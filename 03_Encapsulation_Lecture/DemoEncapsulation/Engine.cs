using System;
using System.Collections.Generic;
using System.Text;

namespace DemoEncapsulation
{
    class Engine
    {
        private Oil oil;
        private Turbo turbo;
        private Karter karter;
        private Cylinders cylinders;

        public void Start()
        {
            oil.Use();
            turbo.Start();
            // karter
            // cilindri
            // butala
            // При запалването на двигателя се стартират всичките тези неща
        }

        public void Stop()
        {
            oil.Stop();
            turbo.Stop();
            // karter
            // cilindri
            // butala
            // При загасянето на двигателя всичките тези неща спират
        }

        public void Accelerate()
        {

        }
    }
}
