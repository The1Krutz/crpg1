namespace PloverCore.Types;

public enum TraitCategory
{
  Ancestry = 0,
  Energy = 1
}

public enum Stat
{
  Strength = 0,
  Dexterity = 1,
  Intelligence = 2,
  Will = 3,
}

public enum Skills
{
  Arcana = 0,
  Examination = 1,
  Finesse = 2,
  Influence = 3,
  Insight = 4,
  Might = 5,
  Lore = 6,
  Naturecraft = 7,
  Perception = 8,
  Stealth = 9
}

public enum ModifierType
{
  /// <summary>
  /// The value should be added
  /// </summary>
  Additive = 0,
  /// <summary>
  /// The value should be multiplied
  /// </summary>
  Multiplicative = 1,
  /// <summary>
  /// An absolute modifier changes the target to a fixed number regardless of the previous value.
  /// ie: Blinded sets VisionDistance to 0 no matter what it was before.
  /// </summary>
  Absolute = 2,
}

public enum ArmorType
{
  Unarmored = 0,
  Medium = 1,
  Heavy = 2,
}

public enum DamageType
{
  Slashing = 0,
  Bludgeoning = 1,
  Piercing = 2,
  Fire = 3,
  Ice = 4,
  Lightning = 5,
  Necrotic = 6,
  Radiant = 7,
}

public enum DieType
{
  d4 = 0,
  d6 = 1,
  d8 = 2,
  d10 = 3,
  d12 = 4,
  d20 = 5,
  d100 = 6,
}
