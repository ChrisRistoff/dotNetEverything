using LeetCode.Easy;

public class StringMatchingInArrayTests
{
    private readonly StringMatchingInArraySolution _solution = new();

    [Fact]
    public void StringMatchingInArrayTest1()
    {
        var words = new string[] { "mass", "as", "hero", "superhero" };
        var expected = new string[] { "as", "hero" };
        var actual = _solution.StringMatching(words);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void StringMatchingInArrayTest2()
    {
        var words = new string[] { "leetcode", "et", "code" };
        var expected = new string[] { "et", "code" };
        var actual = _solution.StringMatching(words);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void StringMatchingInArrayTest3()
    {
        var words = new string[] { "blue", "green", "bu" };
        var expected = new string[] { };
        var actual = _solution.StringMatching(words);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void StringMatchingInArrayTest4()
    {
        var words = new string[] { "leetcoder", "leetcode", "od", "hamlet", "am" };
        var expected = new string[] { "leetcode", "od", "am" };
        var actual = _solution.StringMatching(words);
        Assert.Equal(expected, actual);
    }
}
