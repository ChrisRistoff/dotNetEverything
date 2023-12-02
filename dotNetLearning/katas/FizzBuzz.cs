public class FizzBuzz
{

    private int Len;
    private int Fizz;
    private int Buzz;
    private string FirstWord;
    private string SecondWord;

    public FizzBuzz(int maxLen, int first, int second, string firstWord, string secondWord)
    {
        if (maxLen < 0 || first < 0 || second < 0)
        {
            throw new InvalidOperationException("Must be postiive integers");
        }

        this.Len = maxLen;
        this.Fizz = first;
        this.Buzz = second;
        this.FirstWord = firstWord;
    }

    public void PlayGame()
    {
        int count = 0;
        for (int i = 1; i < this.Len + 1; i++)
        {

            string curr = "";
            if (i % this.Fizz == 0)
            {
                curr += "Fizz";
            }

            if (i % this.Buzz == 0)
            {
                curr += "Buzz";
            }

            if (curr == "")
            {
                System.Console.WriteLine(i);
            }

            else
            {
                System.Console.WriteLine(curr);
                count++;
            }

        }

        System.Console.WriteLine(count);
    }

}
