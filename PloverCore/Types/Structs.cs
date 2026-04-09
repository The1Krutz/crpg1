namespace PloverCore.Types;

public struct Modifier
{
  public ModifierType Type;
  public int Amount;
}

public struct Trait
{
  public int Id;
  public TraitCategory Category;
  public string Name;
  public string Description;
}

public struct Condition
{
  public string Name;
  public string Description;
  public Stat Modifies;
  public Modifier Modifier;
}
