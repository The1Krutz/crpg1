namespace PloverCore.Enums;

public struct Modifier
{
  public ModifierType Type;
  public int Amount;
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
