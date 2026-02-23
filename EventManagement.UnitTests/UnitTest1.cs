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

    [Fact(DisplayName = "Should skip this test")]
    [Trait("Category", "Skip")]
    public void Test3()
    {
        Assert.True(true);
    }

    [Fact(DisplayName = "Should skip this test")]
    [Trait("Category", "Skip")]
    public void Test4()
    {
        Assert.True((1+1) == 2);
    }

    [Fact(DisplayName = "Should skip this test")]
    [Trait("Category", "Skip")]
    public void Test9()
    {
        Assert.True((3-1) == 0);
    }

    [Fact(DisplayName = "Should skip this test")]
    [Trait("Category", "Skip")]
    public void Test6()
    {
        Assert.True((1+5) == 2);
    }

    [Fact(DisplayName = "Should skip this test")]
    [Trait("Category", "Skip")]
    public void Test5()
    {
        Assert.True((1+9) == 2);
    }
}
