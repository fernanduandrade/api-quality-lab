namespace EventManagement.UnitTests;

public class UnitTest1
{
    [Fact(DisplayName = "Should pass this test")]
    [Trait("Category", "Success")]
    public void Test1()
    {
        Assert.True(true);
    }

    [Fact(DisplayName = "Should fail this test")]
    [Trait("Category", "Failure")]
    public void Test2()
    {
        Assert.True(false);
    }
}
