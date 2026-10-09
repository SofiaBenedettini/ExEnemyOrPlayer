using System.Numerics;

namespace BlaisePascal.ExEnemyOrPlayer
{
    internal class Program
    {
        public static void Main()
        {
            Console.WriteLine("=== PLAYER CLASS TEST ===");

            // 1. Player Creation
            Player player = new Player("Arthur");
            Console.WriteLine($"[Name: {player.Name}] Level: {player.Level} | XP: {player.Experience} | Health: {player.Health}/{player.MaxHealth} | IsAlive: {player.IsAlive} | Gold: {player.Gold}");

            // 2. Experience and Level Up Test
            Console.WriteLine("--- Experience and Level Up ---");
            Console.WriteLine("Adding 50 XP:");
            player.AddExperience(50);
            Console.WriteLine($"[Name: {player.Name}] Level: {player.Level} | XP: {player.Experience} | Health: {player.Health}/{player.MaxHealth} | IsAlive: {player.IsAlive} | Gold: {player.Gold}");

            Console.WriteLine("Adding 70 XP (Total 120 XP -> Level 2, 20 XP remaining):");
            player.AddExperience(70);
            Console.WriteLine($"[Name: {player.Name}] Level: {player.Level} | XP: {player.Experience} | Health: {player.Health}/{player.MaxHealth} | IsAlive: {player.IsAlive} | Gold: {player.Gold}");

            Console.WriteLine("Adding 250 XP (Multiple Level Up -> +2 Levels, 70 XP remaining):");
            player.AddExperience(250);
            Console.WriteLine($"[Name: {player.Name}] Level: {player.Level} | XP: {player.Experience} | Health: {player.Health}/{player.MaxHealth} | IsAlive: {player.IsAlive} | Gold: {player.Gold}");

            // 3. Reset Experience Test
            Console.WriteLine("--- Reset Experience ---");
            player.ResetExperience();
            Console.WriteLine($"After ResetExperience() -> XP: {player.Experience}");

            // 4. Gold Test
            Console.WriteLine("--- Gold Test ---");
            player.AddGold(100);
            Console.WriteLine($"Gold added -> Current Gold: {player.Gold}");

            // 5. Damage and Heal Test
            Console.WriteLine("--- Damage and Heal ---");
            Console.WriteLine("Taking 30 damage:");
            player.TakeDamage(30);
            Console.WriteLine($"[Name: {player.Name}] Level: {player.Level} | XP: {player.Experience} | Health: {player.Health}/{player.MaxHealth} | IsAlive: {player.IsAlive} | Gold: {player.Gold}");

            Console.WriteLine("Healing 15 HP:");
            player.Heal(15);
            Console.WriteLine($"[Name: {player.Name}] Level: {player.Level} | XP: {player.Experience} | Health: {player.Health}/{player.MaxHealth} | IsAlive: {player.IsAlive} | Gold: {player.Gold}");

            Console.WriteLine("Healing 50 HP (Overheal: cannot exceed MaxHealth):");
            player.Heal(50);
            Console.WriteLine($"[Name: {player.Name}] Level: {player.Level} | XP: {player.Experience} | Health: {player.Health}/{player.MaxHealth} | IsAlive: {player.IsAlive} | Gold: {player.Gold}");

            // 6. Death and Reset Health Test
            Console.WriteLine("--- Death and Reset Health ---");
            Console.WriteLine("Taking 100 damage (Player dies):");
            player.TakeDamage(100);
            Console.WriteLine($"[Name: {player.Name}] Level: {player.Level} | XP: {player.Experience} | Health: {player.Health}/{player.MaxHealth} | IsAlive: {player.IsAlive} | Gold: {player.Gold}");

            Console.WriteLine("Restoring health with ResetHealth():");
            player.ResetHealth();
            Console.WriteLine($"[Name: {player.Name}] Level: {player.Level} | XP: {player.Experience} | Health: {player.Health}/{player.MaxHealth} | IsAlive: {player.IsAlive} | Gold: {player.Gold}");

            // 7. Invalid Parameters Test
            Console.WriteLine("--- Invalid Parameters Test ---");

            Console.WriteLine("Trying AddExperience(-50):");
            try
            {
                player.AddExperience(-50);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"  Caught Exception: {ex.Message}");
            }

            Console.WriteLine("Trying AddExperience(0):");
            try
            {
                player.AddExperience(0);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"  Caught Exception: {ex.Message}");
            }

            Console.WriteLine("Trying TakeDamage(-20):");
            try
            {
                player.TakeDamage(-20);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"  Caught Exception: {ex.Message}");
            }

            Console.WriteLine("Trying Heal(-10):");
            try
            {
                player.Heal(-10);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"  Caught Exception: {ex.Message}");
            }

            Console.WriteLine("Trying AddGold(-100):");
            try
            {
                player.AddGold(-100);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"  Caught Exception: {ex.Message}");
            }

            Console.WriteLine("=== FINAL PLAYER STATE ===");
            Console.WriteLine($"[Name: {player.Name}] Level: {player.Level} | XP: {player.Experience} | Health: {player.Health}/{player.MaxHealth} | IsAlive: {player.IsAlive} | Gold: {player.Gold}");
        }
    }
}