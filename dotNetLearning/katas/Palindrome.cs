public class Palindrome
{
    private string String;

    public Palindrome(string str)
    {
        if(string.IsNullOrWhiteSpace(str))
        {
            throw new InvalidOperationException("Strings can not be null or empty");
        }

       this.String = str;
    }

    public bool CheckPali()
    {
        string[] symbolsToRemove = new string[] {"!", ",", " ", "?", "."};
        for (int i = 0; i < symbolsToRemove.Length; i++)
        {
            this.String = this.String.Replace(symbolsToRemove[i], "");
        }

        this.String = this.String.ToLower();

        string reversed = new String("");

        for (int i = this.String.Length-1; i >= 0 ; i--)
        {
            reversed += this.String[i];
        }

        return this.String == reversed;
    }
}
