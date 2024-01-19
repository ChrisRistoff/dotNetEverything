using LeetCode.Easy;

public class PlusOneTests
{
    [Fact]
    public void PlusOneTest1()
    {
        var solution = new PlusOneSolution();
        var result = solution.PlusOne(new int[] { 1, 2, 3 });
        Assert.Equal(new int[] { 1, 2, 4 }, result);
    }

    [Fact]
    public void PlusOneTest2()
    {
        var solution = new PlusOneSolution();
        var result = solution.PlusOne(new int[] { 4, 3, 2, 1 });
        Assert.Equal(new int[] { 4, 3, 2, 2 }, result);
    }

    [Fact]
    public void PlusOneTest3()
    {
        var solution = new PlusOneSolution();
        var result = solution.PlusOne(new int[] { 9 });
        Assert.Equal(new int[] { 1, 0 }, result);
    }

    [Fact]
    public void PlusOneTest4()
    {
        var solution = new PlusOneSolution();
        var result = solution.PlusOne(new int[] { 0 });
        Assert.Equal(new int[] { 1 }, result);
    }

    [Fact]
    public void PlusOneTest5()
    {
        var solution = new PlusOneSolution();
        var result = solution.PlusOne(new int[] { 9, 9 });
        Assert.Equal(new int[] { 1, 0, 0 }, result);
    }

    [Fact]
    public void PlusOneTest6()
    {
        var solution = new PlusOneSolution();
        var result = solution.PlusOne(new int[] { 1, 9 });
        Assert.Equal(new int[] { 2, 0 }, result);
    }
}
