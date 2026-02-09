
namespace PloverCore;

public class Character
{
  public string Name = "Placeholder";

  public List<Trait> Traits = [
  ];

  public int MaxHp = 0;
  public int CurrentHP = 0;

  // Default constructor
  public Character(string name, int maxHp, List<Trait> traits)
  {
    Name = name;
    MaxHp = maxHp;
    CurrentHP = maxHp;

    Traits = [.. traits];
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
