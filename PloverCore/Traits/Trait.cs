namespace PloverCore;

public struct Trait
{
  public int Id;
  public TraitCategory Category;
  public string Name;
  public string Description;
}

public enum TraitCategory
{
  Ancestry,
  Energy
}