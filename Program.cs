class Program
{

    static void Main(string[] args)
    {
        testLinkedList();
    }

    static void testLinkedList()
    {
        LinkedList<int> newList = new LinkedList<int>();

        newList.Append(10);
        newList.Append(13);
        newList.Append(23);
        newList.Append(34);
        newList.Append(47);
        newList.PrintList();
        System.Console.WriteLine(newList.Head!.Data + " <-- HEAD");
        System.Console.WriteLine(newList.Tail!.Data + " < -- TAIL");
    }

}
