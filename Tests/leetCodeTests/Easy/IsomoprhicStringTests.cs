using LeetCode.Easy;

public class IsomorphicStringsTests
{
    private readonly IsomorphicStringsSolution _solution = new();

    [Fact]
    public void Example1()
    {
        string s = "egg";
        string t = "add";
        bool expected = true;
        bool actual = _solution.IsIsomorphic(s, t);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Example2()
    {
        string s = "foo";
        string t = "bar";
        bool expected = false;
        bool actual = _solution.IsIsomorphic(s, t);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Example3()
    {
        string s = "paper";
        string t = "title";
        bool expected = true;
        bool actual = _solution.IsIsomorphic(s, t);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Example4()
    {
        string s = "badc";
        string t = "baba";
        bool expected = false;
        bool actual = _solution.IsIsomorphic(s, t);
        Assert.Equal(expected, actual);
    }
}
