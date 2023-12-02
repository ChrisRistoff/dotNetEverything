namespace Tests;
using Xunit;

public class LinkedListMethods
{

    [Fact]
    public void AppendList_AppendsAnItemToTheList()
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
    public void AppendLeft_AppendsAnItemToTheListLeft()
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

    [Fact]
    public void Pop_RemovesLastItemOfListAndReturnValue()
    {
        // create linkedList
        var linkedList = new LinkedList<int>();
        linkedList.Append(1);
        linkedList.Append(2);
        linkedList.Append(3);
        linkedList.Append(4);
        var list = linkedList.PrintList();

        Assert.Equal("1, 2, 3, 4", list);


        Assert.Equal(4, linkedList.Pop());
        Assert.Equal(3, linkedList.Pop());
        Assert.Equal(1, linkedList.Head?.Data);
        Assert.Equal(2, linkedList.Tail?.Data);
        Assert.Equal("1, 2", linkedList.PrintList());

        // check if both head and tail get updated when only one item is left
        Assert.Equal(2, linkedList.Pop());
        Assert.Equal(1, linkedList.Head!.Data);
        Assert.Equal(1, linkedList.Tail!.Data);

        // check if last item is being properly removed
        Assert.Equal(1, linkedList.Pop());
        Assert.Null(linkedList.Tail);
        Assert.Null(linkedList.Head);

        Assert.Throws<InvalidOperationException>(() => linkedList.Pop());
    }

    [Fact]
    public void PopLeft_RemovesFirstItemOfListAndReturnValue()
    {
        // create linkedList
        var linkedList = new LinkedList<int>();
        linkedList.Append(1);
        linkedList.Append(2);
        linkedList.Append(3);
        linkedList.Append(4);

        Assert.Equal(1, linkedList.PopLeft());
        Assert.Equal(2, linkedList.PopLeft());
        Assert.Equal(4, linkedList.Tail?.Data);
        Assert.Equal(3, linkedList.Head?.Data);
        Assert.Equal("3, 4", linkedList.PrintList());

        // check if both head and tail get updated when only one item is left
        Assert.Equal(3, linkedList.PopLeft());
        Assert.Equal(4, linkedList.Head!.Data);
        Assert.Equal(4, linkedList.Tail!.Data);

        // check if last item is being properly removed
        Assert.Equal(4, linkedList.Pop());
        Assert.Null(linkedList.Tail);
        Assert.Null(linkedList.Head);

        Assert.Throws<InvalidOperationException>(() => linkedList.Pop());
    }


    [Fact]
    public void GetByIndex_RetrievesValueOfItemAtAGivenIndex()
    {
        var linkedList = new LinkedList<int>();

        linkedList.Append(1);
        linkedList.Append(2);
        linkedList.Append(3);
        linkedList.Append(4);

        Assert.Equal(1, linkedList.GetByIndex(0));
        Assert.Equal(2, linkedList.GetByIndex(1));
        Assert.Equal(3, linkedList.GetByIndex(2));
        Assert.Equal(4, linkedList.GetByIndex(3));

    }

    [Fact]
    public void GetByIndex_ThrowsErrorWhenListIsEmpty_IndexIsOutOfRange()
    {
        var linkedList = new LinkedList<int>();

        Assert.Throws<InvalidOperationException>(() => linkedList.GetByIndex(0));
        Assert.Throws<InvalidOperationException>(() => linkedList.GetByIndex(3));

        linkedList.Append(1);
        linkedList.Append(2);
        linkedList.Append(3);

        Assert.Equal(1, linkedList.GetByIndex(0));
        Assert.Throws<InvalidOperationException>(() => linkedList.GetByIndex(3));
    }
}
