using PloverCore.Types;

namespace PloverCore.Classes;

public class Monster
{
  public string Name = "Placeholder";

  public List<Trait> Traits = [
    AllTraits.Humanoid
  ];

  public int MaxHp;
  public int CurrentHP;

  public ArmorType Armor = ArmorType.Unarmored;

  public float ChallengeRating = 1;

  public List<Attack> Attacks = [
    new Attack(){
      Name="Stab",
      Range=0,
      Damage=new Roll(){
        DieCount=                                 1,
        DieType = DieType.d6,
        Modifier = 2,
      }
    },
    new Attack(){
      Name="Shoot",
      Range=8,
      Damage=new Roll(){
        DieCount=1,
        DieType = DieType.d6,
        Modifier = 2,
      }
    }
  ];

  public Monster(string name, int maxHp)
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
    Console.WriteLine($"Monster {Name} has died!");
  }
}
