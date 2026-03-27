namespace PloverCore.Conditions;

public interface ICondition
{
  public void onBeforeAttackIn();
  public void onAfterAttackIn();
  public void onBeforeAttackOut();
  public void onAfterAttackOut();

  public string getDescription();
}
