namespace PloverCore;

public static partial class AllTraits
{
  public static readonly Trait Humanoid = new()
  {
    Id = 1,
    Category = TraitCategory.Ancestry,
    Name = "Human",
    Description = "You know what a human is"
  };

  public static readonly Trait Goblin = new()
  {
    Id = 4,
    Category = TraitCategory.Ancestry,
    Name = "Goblin",
    Description = "Freaky little green dudes"
  };
}