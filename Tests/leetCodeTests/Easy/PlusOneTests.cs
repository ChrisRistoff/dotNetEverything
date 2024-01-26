using LeetCode.Easy;

public class PlusOneTests
{
    private readonly PlusOneSolution _solution = new();

    [Fact]
    public void PlusOneTest1()
    {
        int[] result = _solution.PlusOne(new int[] { 1, 2, 3 });
        Assert.Equal(new int[] { 1, 2, 4 }, result);
    }

    [Fact]
    public void PlusOneTest2()
    {
        int[] result = _solution.PlusOne(new int[] { 4, 3, 2, 1 });
        Assert.Equal(new int[] { 4, 3, 2, 2 }, result);
    }

    [Fact]
    public void PlusOneTest3()
    {
        int[] result = _solution.PlusOne(new int[] { 9 });
        Assert.Equal(new int[] { 1, 0 }, result);
    }

    [Fact]
    public void PlusOneTest4()
    {
        int[] result = _solution.PlusOne(new int[] { 0 });
        Assert.Equal(new int[] { 1 }, result);
    }

    [Fact]
    public void PlusOneTest5()
    {
        int[] result = _solution.PlusOne(new int[] { 9, 9 });
        Assert.Equal(new int[] { 1, 0, 0 }, result);
    }

    [Fact]
    public void PlusOneTest6()
    {
        int[] result = _solution.PlusOne(new int[] { 1, 9 });
        Assert.Equal(new int[] { 2, 0 }, result);
    }
}
