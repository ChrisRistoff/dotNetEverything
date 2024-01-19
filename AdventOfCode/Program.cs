class Program
{
    static void Main(string[] args)
    {
        AdventDay5();
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

    static void AdventDay4()
    {
        var advent = new AdventDayFour();
        string[] data = advent.GetData();
        // Console.WriteLine(advent.Calculate(data));
        advent.CalculatePartTwo(data);
    }

    static void AdventDay5()
    {
        var advent = new AdventDayFive();
        string[] data = advent.GetData();
    }
}
