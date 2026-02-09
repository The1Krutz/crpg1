namespace PloverCore;

public static partial class AllTraits
{
  public static readonly Trait Fire = new()
  {
    Id = 2,
    Category = TraitCategory.Energy,
    Name = "Fire",
    Description = "Drop it like it's hot"
  };

  public static readonly Trait Electricity = new()
  {
    Id = 3,
    Category = TraitCategory.Energy,
    Name = "Electricity",
    Description = "Zippity zap"
  };
}