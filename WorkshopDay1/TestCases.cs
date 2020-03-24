using Xunit;

namespace Workshop
{
public class TestCases
{

    //[Fact]
    [Theory]
    [InlineData(5,5)]
    [InlineData(5,5)]
    public void PassingAddTest(int value1, int value2)
    {
        Assert.Equal(10, Program.Add(value1, value2));

    }

    [Theory]
    [InlineData(5)]
    public void PassingIsModOfTwo(int value1)
    {
        Assert.Equal(false, Program.IsModOfTwo(value1));

    }
    
    
}
}