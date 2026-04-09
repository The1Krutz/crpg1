using PloverCore.Traits;

namespace PloverCore;

public class Character
{
  public string Name = "Placeholder";

  public List<Trait> Traits = [
    AllTraits.Humanoid
  ];

  public int MaxHp;
  public int CurrentHP;

  /// <summary>
  /// Default constructor
  /// </summary>
  /// <param name="name"></param>
  /// <param name="maxHp"></param>
  /// <param name="traits"></param>
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
