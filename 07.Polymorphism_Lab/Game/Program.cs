using System;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            GamesMagazine games = new GamesMagazine();
            games.AddGame(new FootballGame());
            games.AddGame(new ChessGame(new Player("Fisher"), new Player("Spasky")));
            games.AddGame(new Tennis(new Player("Nadal"), new Player("Djokovic")));

            games.StartGames();
            games.StopGames();
            games.PrintDescriptions();
            
        }
    }
}
