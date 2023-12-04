class Program
{

    static void Main(string[] args)
    {
        AdventDay3();
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

    static void playWithMap()
    {
        var map = new HashMap(30);
        map.Set("key1", "val1");
        map.Set("key2", "val2");
        map.Set("key3", "val3");

        System.Console.WriteLine(map.PrintMap());
    }

    static void playFB()
    {
        var game = new FizzBuzz(40, 3, 5, "Bazz", "Jazz");
        game.PlayGame();
    }

    static void CheckPali()
    {
        var word1 = new Palindrome("r");
        System.Console.WriteLine(word1.CheckPali());
        var word2 = new Palindrome("racecars");
        System.Console.WriteLine(word2.CheckPali());

        var sentence = new Palindrome("A man, a plan, a canal, Panama???");
        System.Console.WriteLine(sentence.CheckPali());
    }

    static void AdventDay1()
    {
        var advent = new AdventDayOne();

        string[] data = advent.GetData();
        advent.GetSumWithStrings(data);
    }

    static void AdventDay2()
    {
        var advent = new AdventDayTwo();
        string[] data = advent.GetData();
        // advent.GetPossibleGames(data);
        advent.GetMinCubes(data);
    }

    static void AdventDay3()
    {
        var advent = new AdventDayThree();
        string[] data = advent.GetData();
        advent.GetSum(data);
    }
}
