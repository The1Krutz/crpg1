namespace PloverCore.Classes.Tests;

public class MonsterTests
{
  [Fact]
  public void Monster_Should_()
  {
    // Arrange
    Monster goblin = new("Goblin", 25);
    int damage = 5;
    int expectedHp = 20;

    // Act
    goblin.TakeDamage(damage);

    // Assert
    Assert.Equal(expectedHp, goblin.CurrentHP);
  }
}
