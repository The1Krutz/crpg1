using PloverCore.Enums;

namespace PloverCore;

public class Character
{
  public string Name = "Placeholder";

  public Dictionary<Enums.Attribute, int> Attributes = new(){
    {Enums.Attribute.Strength, 10},
    {Enums.Attribute.Dexteriry, 10},
    {Enums.Attribute.Constitution, 10},
    {Enums.Attribute.Intelligence, 10},
    {Enums.Attribute.Wisdom, 10},
    {Enums.Attribute.Charisma, 10},
  };

  public List<Trait> Traits = [
    AllTraits.Humanoid
  ];

  public int MaxHp;
  public int CurrentHP;

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
