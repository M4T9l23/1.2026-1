namespace ArenaGame;

public interface IAttackable
{
    int CurrentHealth { get; }
    void TakeDamage(int amount);
    bool IsAlive { get; }
}