namespace ArenaGame;

public class Troll : Enemy
{
    public Troll() : base("Troll", 80, 20)
    {
    }

    public override void DoTurn(Character opponent)
    {
        int regen = 5;
        CurrentHealth += regen;
        if (CurrentHealth > MaxHealth)
            CurrentHealth = MaxHealth;

        Console.WriteLine("Troll regenerates 5 HP");
        base.DoTurn(opponent);
    }
}