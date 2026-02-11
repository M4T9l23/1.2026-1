namespace ArenaGame;

public class Goblin : Enemy
{
    public Goblin() : base("Goblin", 40, 8)
    {
    }

    public override int CalculateDamage()
    {
        if (random.Next(100) < 20)
            return BaseDamage * 2;

        return BaseDamage;
    }

    public override void DoTurn(Character opponent)
    {
        if (CurrentHealth < MaxHealth * 0.3)
        {
            Console.WriteLine("Goblin tries to flee but fails");
        }

        base.DoTurn(opponent);
    }
}