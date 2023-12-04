public class AdventDayThree
{
    public string[] GetData()
    {
        string filepath = "./adventOfCode/2023/day3/testData.txt";
        string[] result = { "empty" };
        string[] lastRemoved = { "temp" };

        try
        {
            string fileContent = File.ReadAllText(filepath);
            result = fileContent.Split("\n");
            lastRemoved = new string[result.Length - 1];

            for (int i = 0; i < lastRemoved.Length; i++)
            {
                lastRemoved[i] = result[i];
            }
        }
        catch (IOException e)
        {
            System.Console.WriteLine("IO Exception");
            System.Console.WriteLine(e.Message);
        }

        return lastRemoved;
    }

    public void GetSum(string[] data)
    {
        int sum = 0;
        for (int i = 0; i < data.Length; i++)
        {
            string currLine = data[i];
            string currNum = "";
            for (int j = 0; j < currLine.Length; j++)
            {
                currNum = "";
                int before = j;
                while (char.IsDigit(currLine[j]))
                {
                    currNum += currLine[j];
                    j++;
                }

                int after = j;

                if (currLine[j] != '.' && !char.IsDigit(currLine[j]))
                {
                    sum += int.Parse(currNum);
                    currNum = "";
                }
                else if (!char.IsDigit(currLine[j]) && currNum != "" && currLine[j] != '.')
                {
                    int prevLine = i - 1;
                    int nextLine = i + 1;
                    if (prevLine < 0) prevLine = 0;
                    if (nextLine > data.Length - 1) nextLine = i;
                    for (int k = before; k <= after; k++)
                    {
                        if (data[prevLine][k] != '.' || data[nextLine][k] != '.')
                        {
                            sum += int.Parse(currNum);
                            currNum = "";
                            break;
                        }
                    }
                }
            }

            currNum = "";
        }

        System.Console.WriteLine(sum);
    }
}
