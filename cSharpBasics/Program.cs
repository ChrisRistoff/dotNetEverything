abstract class Program
{
    static void Main(string[] args)
    {
        MaxProductDiff();
    }

    static void ConcatArr()
    {
        var concat = new ConcatArray();
        Console.WriteLine(String.Join(",", concat.GetConcat([1,2,3,4])));
    }

    static void MaxProductDiff()
    {
        var maxProdDiff = new MaximumProductDifference();
        int res = maxProdDiff.MaxProductDifference([5,9,4,6]);
        int res2 = maxProdDiff.MaxProductDifference([10,10,10,10]);
        int res3 = maxProdDiff.MaxProductDifference([4,10,2,2,8,2,9,3,3]);

        Console.WriteLine(res + " Result 1");
        Console.WriteLine(res2 + " Result 2");
        Console.WriteLine(res3 + " Result 3");

        // Console.WriteLine(((10 * 9) - (2 * 2)) + " Test Result");
    }
}
