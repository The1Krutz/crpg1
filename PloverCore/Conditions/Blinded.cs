namespace PloverCore.Conditions;

public class Blinded : ICondition
{
  string ICondition.getDescription() => "Can't see. Attacks against you have advantage, and your attacks have disadvantage";

  void ICondition.onAfterAttackIn()
  {
    ///
    /// This is a really dumb way to do this, and you need to do better
    ///
    return;
  }
  void ICondition.onAfterAttackOut()
  {
    return;
  }
  void ICondition.onBeforeAttackIn()
  {
    // todo - grant advantage to the incoming attack
  }
  void ICondition.onBeforeAttackOut()
  {
    // todo - grant disadvantage to the outgoing attack
  }
}
