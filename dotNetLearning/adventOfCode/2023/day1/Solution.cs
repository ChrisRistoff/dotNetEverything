using System.Text.RegularExpressions;

public class AdventDayOne
{

    public string[] GetData()
    {
        string filepath = "./adventOfCode/2023/day1/data.txt";
        string[] result = ["empty"];
        string[] lastItemRemoved = ["temp"];
        try
        {
            string fileContent = File.ReadAllText(filepath);
            result = fileContent.Split("\n");
            lastItemRemoved = new string[result.Length - 1];

            int len = lastItemRemoved.Length;
            for (int i = 0; i < len; i++)
            {
                lastItemRemoved[i] = result[i];
                System.Console.WriteLine(lastItemRemoved[i]);
            }
        }
        catch (IOException e)
        {
            System.Console.WriteLine("IO Exception");
            System.Console.WriteLine(e.Message);
        }

        return lastItemRemoved;
    }

    public void GetSum(string[] data)
    {
        int sum = 0;
        bool first = false;
        for (int i = 0; i < data.Length; i++)
        {
            var lastDigit = "";
            string tempDigit = "";
            foreach (char letter in data[i])
            {
                if (char.IsDigit(letter))
                {
                    if (!first)
                    {
                        tempDigit += letter;
                        lastDigit += letter;
                        first = true;
                    }
                    else
                    {
                        lastDigit = "";
                        lastDigit += letter;
                    }
                }
            }

            first = false;
            tempDigit += lastDigit;
            System.Console.WriteLine(tempDigit);
            sum += int.Parse(tempDigit);
        }

        System.Console.WriteLine(sum);
    }
}
