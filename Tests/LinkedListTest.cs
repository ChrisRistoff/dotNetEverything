namespace Tests;
using Xunit;

public class LinkedListMethods
{

    [Fact]
    public void AppendList()
    {
        var linkedList = new LinkedList<int>();
        linkedList.Append(1);
        linkedList.Append(12);
        linkedList.Append(21);
        string list = linkedList.PrintList();

        Assert.Equal(1, linkedList.Head!.Data);
        Assert.Equal(21, linkedList.Tail!.Data);
        Assert.Equal("1, 12, 21", list);
    }

    [Fact]
    public void AppendLeft()
    {
        var linkedList = new LinkedList<int>();
        linkedList.AppendLeft(3);
        linkedList.AppendLeft(2);
        linkedList.AppendLeft(1);
        string list = linkedList.PrintList();

        Assert.Equal(1, linkedList.Head!.Data);
        Assert.Equal(3, linkedList.Tail!.Data);
        Assert.Equal("1, 2, 3", list);
    }
}
