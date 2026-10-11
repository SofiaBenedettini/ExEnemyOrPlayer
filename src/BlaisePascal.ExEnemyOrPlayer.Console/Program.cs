using System.Numerics;

namespace BlaisePascal.ExEnemyOrPlayer
{
    internal class Program
    {
        public static void Main()
        {
            Player player1 = new Player("Sofia");
            Enemy enemy1 = new Enemy("Vampire", 100, 25);

            player1.AddExperienxce(65);
            player1.TakeDamage(20);
            player1.Heal(10);
            player1.AddGold(34);

            Console.WriteLine("The stats of the player are: ");
            Console.WriteLine($"XP: {player1.Experience}");
            Console.WriteLine($"Is alive: {player1.IsAlive}");
            Console.WriteLine($"Health: {player1.Health}");
            Console.WriteLine($"Gold: {player1.Gold}");

            enemy1.TakeDamage(23);

            Console.WriteLine("The stats of the enemy are: ");
            Console.WriteLine($"Is alive: {enemy1.IsAlive()}");
            Console.WriteLine($"HEalth: {enemy1.Health}");
        }
    }
}
