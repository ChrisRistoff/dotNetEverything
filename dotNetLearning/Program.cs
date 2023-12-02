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
        System.Console.WriteLine(newList.PrintList());
        System.Console.WriteLine(newList.GetByIndex(0));
        System.Console.WriteLine(newList.GetByIndex(1));
        System.Console.WriteLine(newList.GetByIndex(2));
        System.Console.WriteLine(newList.GetByIndex(3));
    }

}
