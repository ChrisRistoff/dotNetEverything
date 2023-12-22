abstract class Program
{
    static void Main(string[] args)
    {
        ConcatArr();
    }

    static void ConcatArr()
    {
        var concat = new ConcatArray();
        Console.WriteLine(String.Join(",", concat.GetConcat([1,2,3,4])));
    }
}
