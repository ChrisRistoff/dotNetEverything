using LeetCode.Easy;

public class StringMatchingInArrayTests
{
    private readonly StringMatchingInArraySolution _solution = new();

    [Fact]
    public void StringMatchingInArrayTest1()
    {
        string[] words = ["mass", "as", "hero", "superhero"];
        string[] expected = ["as", "hero"];
        IList<string> actual = _solution.StringMatching(words);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void StringMatchingInArrayTest2()
    {
        string[] words = ["leetcode", "et", "code"];
        string[] expected = ["et", "code"];
        IList<string> actual = _solution.StringMatching(words);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void StringMatchingInArrayTest3()
    {
        string[] words = ["blue", "green", "bu"];
        string[] expected = [];
        IList<string> actual = _solution.StringMatching(words);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void StringMatchingInArrayTest4()
    {
        string[] words = ["leetcoder", "leetcode", "od", "hamlet", "am"];
        string[] expected = ["leetcode", "od", "am"];
        IList<string> actual = _solution.StringMatching(words);
        Assert.Equal(expected, actual);
    }
}
