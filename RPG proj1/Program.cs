using ArenaGame;

namespace ArenaGame;

internal class Program
{
    private static void Main()
    {
        Console.Write("Enter name: ");
        var name = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(name))
            name = "Hero";

        Player player = new Player(name);

        List<Enemy> enemies = new List<Enemy>
        {
            new Goblin(),
            new Troll(),
            new Dragon()
        };

        Console.WriteLine("\nWelcome to the game \n");

        foreach (var enemy in enemies)
        {
            Console.WriteLine($"\nA {enemy.Name} appears");

            while (player.IsAlive && enemy.IsAlive)
            {
                Console.WriteLine($"\n{player.Name} HP: {player.CurrentHealth}/{player.MaxHealth}");
                Console.WriteLine($"{enemy.Name} HP: {enemy.CurrentHealth}/{enemy.MaxHealth}\n");

                player.DoTurn(enemy);

                if (enemy.IsAlive)
                    enemy.DoTurn(player);
            }

            if ( !player.IsAlive)
            {
                Console.WriteLine("You have been defeated");
                return;
            }

            Console.WriteLine($"{enemy.Name} defeated");
        }

        Console.WriteLine("You defeated all enemies ");
    }
}