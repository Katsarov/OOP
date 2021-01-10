using AbstractedRendering.Contracts;
using AbstractedRendering.Drawers;
using System;

namespace AbstractedRendering
{
    class Program
    {
        static void Main(string[] args)
        {
            //IDrawer drawer = new ConsoleDrawer();
            
            //IDrawer drawer = new FileDrawer("../../../game,txt");
           
            IDrawer drawer = new HtmlDrawer("../../../game");

            Game game = new Game(drawer);
            game.Start();
        }
    }
}
