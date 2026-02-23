namespace EventManagement.UnitTests;

public class UnitTest1
{
    // --- PASSING TESTS ---

    [Fact(DisplayName = "1 + 1 should equal 2")]
    [Trait("Category", "Math")]
    public void Addition_Simple() => Assert.Equal(2, 1 + 1);

    [Fact(DisplayName = "10 - 3 should equal 7")]
    [Trait("Category", "Math")]
    public void Subtraction_Simple() => Assert.Equal(7, 10 - 3);

    [Fact(DisplayName = "5 * 4 should equal 20")]
    [Trait("Category", "Math")]
    public void Multiplication_Simple() => Assert.Equal(20, 5 * 4);

    [Fact(DisplayName = "Empty string should have length 0")]
    [Trait("Category", "String")]
    public void EmptyString_LengthZero() => Assert.Equal(0, string.Empty.Length);

    [Fact(DisplayName = "Non-empty string should not be null")]
    [Trait("Category", "String")]
    public void NonEmptyString_NotNull() => Assert.NotNull("hello");

    [Fact(DisplayName = "String contains substring")]
    [Trait("Category", "String")]
    public void String_Contains_Substring() => Assert.Contains("world", "hello world");

    [Fact(DisplayName = "List count after adding items")]
    [Trait("Category", "Collections")]
    public void List_Count_AfterAdd()
    {
        var list = new List<int> { 1, 2, 3 };
        Assert.Equal(3, list.Count);
    }

    [Fact(DisplayName = "Dictionary should contain added key")]
    [Trait("Category", "Collections")]
    public void Dictionary_ContainsKey()
    {
        var dict = new Dictionary<string, int> { ["a"] = 1 };
        Assert.True(dict.ContainsKey("a"));
    }

    [Fact(DisplayName = "Dictionary should not contain missing key")]
    [Trait("Category", "Collections")]
    public void Dictionary_DoesNotContainKey()
    {
        var dict = new Dictionary<string, int> { ["a"] = 1 };
        Assert.False(dict.ContainsKey("b"));
    }

    [Fact(DisplayName = "True is not false")]
    [Trait("Category", "Logic")]
    public void True_IsNotFalse() => Assert.NotEqual(true, false);

    [Fact(DisplayName = "Null object should be null")]
    [Trait("Category", "Logic")]
    public void NullObject_IsNull()
    {
        object? obj = null;
        Assert.Null(obj);
    }

    [Fact(DisplayName = "Type check for integer")]
    [Trait("Category", "Types")]
    public void Integer_IsValueType()
    {
        int x = 42;
        Assert.IsType<int>(x);
    }

    [Fact(DisplayName = "Guid should not be empty")]
    [Trait("Category", "Types")]
    public void NewGuid_NotEmpty() => Assert.NotEqual(Guid.Empty, Guid.NewGuid());

    // --- FAILING TESTS ---

    [Fact(DisplayName = "FAIL: 2 + 2 should not equal 5")]
    [Trait("Category", "Failure")]
    public void Fail_BadAddition() => Assert.Equal(5, 2 + 2);

    [Fact(DisplayName = "FAIL: empty string is not null")]
    [Trait("Category", "Failure")]
    public void Fail_EmptyIsNotNull() => Assert.Null(string.Empty);

    [Fact(DisplayName = "FAIL: false should be true")]
    [Trait("Category", "Failure")]
    public void Fail_FalseIsTrue() => Assert.True(false);

    [Fact(DisplayName = "FAIL: list should not be empty")]
    [Trait("Category", "Failure")]
    public void Fail_ListNotEmpty()
    {
        var list = new List<int>();
        Assert.NotEmpty(list);
    }

    [Fact(DisplayName = "FAIL: 10 / 2 does not equal 3")]
    [Trait("Category", "Failure")]
    public void Fail_BadDivision() => Assert.Equal(3, 10 / 2);

    [Fact(DisplayName = "FAIL: string does not start with wrong prefix")]
    [Trait("Category", "Failure")]
    public void Fail_StartsWith() => Assert.StartsWith("xyz", "hello world");
}
