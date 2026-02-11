namespace ArenaGame;

public class Player : Character, IAttacker, ISpecialAbility
{
    public int Potions { get; private set; } = 2;

    public Player(string name)
        : base(name, 100, 15)
    {
    }

    public override void DoTurn(Character opponent)
    {
        Console.WriteLine("Choose action:");
        Console.WriteLine("1 - Attack");
        Console.WriteLine("2 - Heal");
        Console.WriteLine("3 - Special Ability");
        Console.Write("Choice: ");

        var choice = Console.ReadLine();

        switch (choice)
        {
            case "2":
                Heal();
                break;
            case "3":
                UseSpecialAbility(opponent);
                break;
            default:
                Attack(opponent);
                break;
        }
    }

    public int Attack(IAttackable target)
    {
        int damage = CalculateDamage();
        target.TakeDamage(damage);
        Console.WriteLine($"{Name} attacks for {damage} damage");
        return damage;
    }

    private void Heal()
    {
        if (Potions <= 0)
        {
            Console.WriteLine("No potions left");
            return;
        }

        int healAmount = 20;
        CurrentHealth += healAmount;
        if (CurrentHealth > MaxHealth)
            CurrentHealth = MaxHealth;

        Potions--;
        Console.WriteLine($"{Name} heals for {healAmount} HP");
    }

    public void UseSpecialAbility(Character target)
    {
        int damage = BaseDamage * 2;
        target.TakeDamage(damage);
        Console.WriteLine($"{Name} uses POWER STRIKE for {damage} damage");
    }
}