namespace ArenaGame;

public abstract class Enemy : Character, IAttacker
{
    protected static Random random = new Random();

    protected Enemy(string name, int maxHealth, int baseDamage)
        : base(name, maxHealth, baseDamage)
    {
    }

    public int Attack(IAttackable target)
    {
        int damage = CalculateDamage();
        target.TakeDamage(damage);
        Console.WriteLine($"{Name} attacks for {damage} damage.");
        return damage;
    }

    public override void DoTurn(Character opponent)
    {
        Attack(opponent);
    }
}