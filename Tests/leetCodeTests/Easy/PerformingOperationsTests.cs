using LeetCode.Easy;

public class PerformingOperationsTests
{
    private readonly PerformingOperationsSolution _solution = new();

    [Fact]
    public void Test1()
    {
        string[] operations = { "--X", "X++", "X++" };
        int result = _solution.FinalValueAfterOperations(operations);
        Assert.Equal(1, result);
    }

    [Fact]
    public void Test2()
    {
        string[] operations = { "++X", "++X", "X++" };
        int result = _solution.FinalValueAfterOperations(operations);
        Assert.Equal(3, result);
    }

    [Fact]
    public void Test3()
    {
        string[] operations = { "X++", "++X", "--X", "X--" };
        int result = _solution.FinalValueAfterOperations(operations);
        Assert.Equal(0, result);
    }

    [Fact]
    public void Test4()
    {
        string[] operations = { "X++", "++X", "--X", "X--", "X++", "++X", "--X", "X--" };
        int result = _solution.FinalValueAfterOperations(operations);
        Assert.Equal(0, result);
    }
}
