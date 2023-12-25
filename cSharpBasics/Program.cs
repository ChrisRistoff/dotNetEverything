abstract class Program
{
    static void Main(string[] args)
    {
        MakeAFancyString();
    }

    static void MakeAFancyString()
    {
        var fancyString = new FancyString();
        Console.WriteLine(fancyString.MakeFancyString("leeetcode"));
        Console.WriteLine(fancyString.MakeFancyString("aaabaaaa"));
        Console.WriteLine(fancyString.MakeFancyString("aab"));
    }

    static void NumberHasThreeDivisors()
    {
        var threeDivisors = new ThreeDivisors();
        Console.WriteLine(threeDivisors.IsThree(2));
        Console.WriteLine(threeDivisors.IsThree(4));
        Console.WriteLine(threeDivisors.IsThree(5));
        Console.WriteLine(threeDivisors.IsThree(12));
    }

    static void SumOfDigitsAfterConvert()
    {
        var sumOfDigits = new SumOfDigitsAfterConvert();
        Console.WriteLine(sumOfDigits.GetLucky("leetcode", 2));
        Console.WriteLine(sumOfDigits.GetLucky("iiii", 1));
    }

    static void AllOccurrences()
    {
        var occurrences = new CheckOccurrences();
        Console.WriteLine(occurrences.AreOccurrencesEqual("aabbcc"));
        Console.WriteLine(occurrences.AreOccurrencesEqual("abbcc"));
    }

    static void MaxNumberOfWords()
    {
        var maxNumOfWrds = new MaxNumberOfWords();
        Console.WriteLine(maxNumOfWrds.CanBeTypedWords("hello world", "ad"));
        Console.WriteLine(maxNumOfWrds.CanBeTypedWords("leet code", "lt"));
        Console.WriteLine(maxNumOfWrds.CanBeTypedWords("leet code", "e"));
    }

    static void CheckAllNumsInRange()
    {
        var check = new CheckRange();
        Console.WriteLine(check.IsCovered([[1,2],[3,4],[5,6]], 2, 5));
        Console.WriteLine(check.IsCovered([[1,10],[10,20]], 2, 5));
    }

    static void LargestOddNumber()
    {
        var largest = new LargestOddNumberInString();

        Console.WriteLine(largest.LargestOddNumber("35427"));
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

    static void StrictlyIncreasing()
    {
        var strictlyInc = new StrictlyIncreasing();

        Console.WriteLine(strictlyInc.CanBeIncreasing([1,2,10,5,7]));
        Console.WriteLine(strictlyInc.CanBeIncreasing([2,3,1,2]));
        Console.WriteLine(strictlyInc.CanBeIncreasing([1,1,1]));
    }
}
