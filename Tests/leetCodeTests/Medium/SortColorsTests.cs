using LeetCode.Medium;

public class SortColorsTests
{
    private readonly SortColorsSolution _solution = new();

    [Fact]
    public void SortColorsTest1()
    {
        int[] input = new[] {2, 0, 2, 1, 1, 0};
        int[] expected = new[] {0, 0, 1, 1, 2, 2};
        _solution.SortColors(input);
        Assert.Equal(expected, input);
    }

    [Fact]
    public void SortColorsTest2()
    {
        int[] input = new[] {2, 0, 1};
        int[] expected = new[] {0, 1, 2};
        _solution.SortColors(input);
        Assert.Equal(expected, input);
    }

    [Fact]
    public void SortColorsTest3()
    {
        int[] input = new[] {0};
        int[] expected = new[] {0};
        _solution.SortColors(input);
        Assert.Equal(expected, input);
    }

    [Fact]
    public void SortColorsTest4()
    {
        int[] input = new[] {1};
        int[] expected = new[] {1};
        _solution.SortColors(input);
        Assert.Equal(expected, input);
    }

    [Fact]
    public void SortColorsTest5()
    {
        int[] input = new[] {0, 2, 1};
        int[] expected = new[] {0, 1, 2};
        _solution.SortColors(input);
        Assert.Equal(expected, input);
    }
}
