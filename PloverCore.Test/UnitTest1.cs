namespace PloverCore.Test;

public class UnitTest1
{
  [Fact]
  public void Test1()
  {

    int expected = 2;
    int result = 1 + 1;

    Assert.Equal(expected, result);
  }
}
