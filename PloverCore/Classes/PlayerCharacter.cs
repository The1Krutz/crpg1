using PloverCore.Types;

namespace PloverCore.Classes;

public class PlayerCharacter
{
  public string Name = "Placeholder";

  public Dictionary<Stat, int> Attributes = new(){
    {Stat.Strength, 1},
    {Stat.Dexterity, 1},
    {Stat.Intelligence, 1},
    {Stat.Will, 1},
  };

  public List<Trait> Traits = [
    AllTraits.Humanoid
  ];

  public int MaxHp;
  public int CurrentHP;

  public PlayerCharacter(string name, int maxHp, List<Trait> traits)
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
