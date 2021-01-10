using AbstractedRendering.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractedRendering
{
    class Food : IGameObject
    {
        public int IsEaten { get; set; }

        public void Draw(IDrawer drawer)
        {
            drawer.WriteLine("HranataAAA!!");
        }
    }
}
