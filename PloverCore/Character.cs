namespace PloverCore;

public class Character
{
  string Name = "Placeholder";
  int MaxHp = 0;
  int CurrentHP = 0;

  public Character(string name, int maxHp)
  {
    this.Name = name;
    this.MaxHp = maxHp;
    this.CurrentHP = maxHp;
  }
}
