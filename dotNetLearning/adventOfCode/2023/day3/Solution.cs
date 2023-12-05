public class AdventDayThree
{

    public string[] GetData()
    {
        string filepath = "./adventOfCode/2023/day3/testData.txt";
        string[] result = {};
        string[] lastRemoved = {};

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
                if (char.IsDigit(currLine[j]))
                {
                    currNum += currLine[j];
                }
                else
                {
                    if (!string.IsNullOrEmpty(currNum))
                    {
                        sum += int.Parse(currNum);
                        currNum = "";
                    }

                    if (currLine[j] == '.' && !string.IsNullOrEmpty(currNum))
                    {
                        int prevLine = i - 1;
                        int nextLine = i + 1;
                        if (prevLine < 0) prevLine = 0;
                        if (nextLine >= data.Length) nextLine = i;

                        for (int k = j; k < currLine.Length && k < data[prevLine].Length && k < data[nextLine].Length; k++)
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
            }

            if (!string.IsNullOrEmpty(currNum))
            {
                sum += int.Parse(currNum);
            }
        }

        System.Console.WriteLine(sum);
    }

}
