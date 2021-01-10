using System;

namespace PlayersAndMonsters
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Hero hero = new Elf("Alderon", 3);

            Console.WriteLine(hero);
        }
    }
}
