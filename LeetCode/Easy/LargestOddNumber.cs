public class LargestOddNumberInString {
    public string LargestOddNumber(string num)
    {
        string result = "";
        int index = -1;

        for (int i = num.Length-1; i >= 0; i--)
        {
            if (+num[i] %2 != 0)
            {
                index = i;
                break;
            }
        }

        result = num.Substring(0, index+1);

        return result;
    }
}
