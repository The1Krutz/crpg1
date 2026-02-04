
namespace PloverCore;

public class Character
{
  string Name = "Placeholder";
  int MaxHp = 0;
  int CurrentHP = 0;

  public Character(string name, int maxHp)
  {
    Name = name;
    MaxHp = maxHp;
    CurrentHP = maxHp;
  }

  public void TakeDamage(int amount)
  {
    CurrentHP -= amount;

    if (CurrentHP <= 0)
    {
      CurrentHP = 0;
      TriggerDeath();
    }
  }

  private void TriggerDeath()
  {
    Console.WriteLine($"Character {Name} has died!");
  }
}
