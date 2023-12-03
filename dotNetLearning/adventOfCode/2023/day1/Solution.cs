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

    public void GetSumWithStrings(string[] data)
    {
        Dictionary<string, string> numsDict = new Dictionary<string, string>();
        numsDict["one"] = "1";
        numsDict["two"] = "2";
        numsDict["three"] = "3";
        numsDict["four"] = "4";
        numsDict["five"] = "5";
        numsDict["six"] = "6";
        numsDict["seven"] = "7";
        numsDict["eight"] = "8";
        numsDict["nine"] = "9";
        int sum = 0;
        bool first = false;
        string numString = "";

        for (int i = 0; i < data.Length; i++)
        {
            var lastDigit = "";
            string tempDigit = "";

            for (int j = 0; j < data[i].Length; j++)
            {
                char letter = data[i][j];
                string currString = data[i];

                string? value;

                for (int h = j; h < data[i].Length; h++)
                {
                    char currLetter = data[i][h];
                    numString += currLetter;

                    if (numsDict.TryGetValue(numString, out value))
                    {
                        if (!first)
                        {
                            tempDigit += value;
                            lastDigit += value;
                            numString = "";
                            first = true;
                        }
                        else
                        {
                            lastDigit = "";
                            lastDigit += value;
                            numString = "";
                        }
                    }
                }

                numString = "";

                if (char.IsDigit(letter))
                {
                    if (!first)
                    {
                        tempDigit += letter;
                        lastDigit += letter;
                        numString = "";
                        first = true;
                    }
                    else
                    {
                        lastDigit = "";
                        lastDigit += letter;
                        numString = "";
                    }
                }
            }

            first = false;
            tempDigit += lastDigit;
            System.Console.WriteLine(tempDigit);
            System.Console.WriteLine(numString);
            sum += int.Parse(tempDigit);
        }

        System.Console.WriteLine(sum);
    }
}
