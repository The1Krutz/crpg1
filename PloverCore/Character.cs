using PloverCore.Enums;
using PloverCore.Types;

namespace PloverCore;

public class Character
{
  public string Name = "Placeholder";

  public Dictionary<Types.Attribute, int> Attributes = new(){
    {Types.Attribute.Strength, 10},
    {Types.Attribute.Dexteriry, 10},
    {Types.Attribute.Constitution, 10},
    {Types.Attribute.Intelligence, 10},
    {Types.Attribute.Wisdom, 10},
    {Types.Attribute.Charisma, 10},
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
