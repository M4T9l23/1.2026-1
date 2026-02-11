namespace ArenaGame;

public class Dragon : Enemy, ISpecialAbility
{
    public Dragon() : base("Dragon", 150, 25)
    {
    }

    public override void DoTurn(Character opponent)
    {
        if (random.Next(100) < 30)
        {
            UseSpecialAbility(opponent);
        }
        else
        {
            base.DoTurn(opponent);
        }
    }

    public void UseSpecialAbility(Character target)
    {
        int damage = BaseDamage + 20;
        target.TakeDamage(damage);
        Console.WriteLine("Dragon uses FIRE BREATH for " + damage + " damage");
    }
}