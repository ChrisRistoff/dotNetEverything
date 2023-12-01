namespace Tests;
using Xunit;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var linkedList = new LinkedList<int>();
        linkedList.Append(1);
        linkedList.Append(12);
        linkedList.Append(21);
        linkedList.Append(34);
        linkedList.Append(48);
        string list = linkedList.PrintList();

        Assert.Equal("1, 12, 21, 34, 48", list);
    }
}
