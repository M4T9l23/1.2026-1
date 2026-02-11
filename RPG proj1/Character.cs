namespace ArenaGame;

public abstract class Character : IAttackable
{
    public string Name { get; }
    public int MaxHealth { get; }
    public int CurrentHealth { get; protected set; }
    public int BaseDamage { get; }

    protected Character(string name, int maxHealth, int baseDamage)
    {
        Name = name;
        MaxHealth = maxHealth;
        CurrentHealth = maxHealth;
        BaseDamage = baseDamage;
    }

    public bool IsAlive => CurrentHealth > 0;

    public void TakeDamage(int amount)
    {
        CurrentHealth -= amount;
        if (CurrentHealth < 0)
            CurrentHealth = 0;
    }

    public virtual int CalculateDamage()
    {
        return BaseDamage;
    }

    public abstract void DoTurn(Character opponent);
}