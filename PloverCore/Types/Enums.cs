namespace PloverCore.Types;

public enum TraitCategory
{
  Ancestry = 0,
  Energy = 1
}

public enum Attribute
{
  Strength = 0,
  Dexteriry = 1,
  Constitution = 2,
  Intelligence = 3,
  Wisdom = 4,
  Charisma = 5,
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
