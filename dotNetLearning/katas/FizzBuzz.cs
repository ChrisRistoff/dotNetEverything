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

        Type firstWordType = firstWord.GetType();
        Type secondWordType = secondWord.GetType();

        if (firstWordType != (typeof(string)) && secondWordType != (typeof(string)))
        {
            throw new InvalidOperationException("Must be strings");
        }

        this.Len = maxLen;
        this.Fizz = first;
        this.Buzz = second;
        this.FirstWord = firstWord;
        this.SecondWord = secondWord;
    }

    public void PlayGame()
    {
        int count = 0;
        for (int i = 1; i < this.Len + 1; i++)
        {

            string curr = "";
            if (i % this.Fizz == 0)
            {
                curr += this.FirstWord;
            }

            if (i % this.Buzz == 0)
            {
                curr += this.SecondWord;
            }

            if (curr == "")
            {
                System.Console.WriteLine("--------" + i);
            }

            else
            {
                System.Console.WriteLine(curr + $"<<< ({i})");
                count++;
            }

        }

        System.Console.WriteLine(count + " <<<<<< Total words");
    }

}
