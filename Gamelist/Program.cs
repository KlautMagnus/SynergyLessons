using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Gamelist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var gamesInfo = GetGamesInfo();

            for (int i = 0; i < gamesInfo.Count; i++)
            {
                Console.WriteLine($"{gamesInfo[i].TypeOfGame}:");

                for (int j = 0; j < gamesInfo.Games.Count; j++)
                {
                    Console.WriteLine($" {gamesInfo[i].Games[j].Name}:");
                }
                Console.WriteLine();

            }
        }

        static List <GameInfo> GetGamesInfo()
        {
            return new List<GameInfo>()
            {
                new GameInfo()
                {
                   TypeOfGame = GameType.RPG,
                   Games = new List<Game>()
                   {
                    new Game() { Name = "Fallout"},
                    new Game() { Name = "Gothic"},
                    new Game() { Name = "Daggerfall"}
                   }
                },
                new GameInfo()
                {
                   TypeOfGame = GameType.Shooter,
                   Games = new List<Game>()
                   {
                    new Game() { Name = "Doom"},
                    new Game() { Name = "Quake"},
                    new Game() { Name = "Wolfenstein"}
                   }

                }
            };

        }  
        
    }


}
