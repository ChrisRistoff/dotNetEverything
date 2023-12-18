public class AdventDayFour
{
    public string[] GetData()
    {
        string filepath = "./adventOfCode/2023/day4/testData.txt";
        string[] result = {};

        try
        {
            string fileContent = File.ReadAllText(filepath);
            result = fileContent.Split("\n");
        }
        catch (IOException e)
        {
            System.Console.WriteLine("IO Exception");
            System.Console.WriteLine(e.Message);
        }

        return result;
    }

    public int Calculate(string[] data)
    {
        int result = 0;
        for (int i = 0; i < data.Length; i++)
        {
            int temp = 0;
            var res = data[i].Split(":");
            res = res[1].Split(" | ");

            string[] first = res[0].Trim().Split(" ");
            string[] second = res[1].Trim().Split(" ");

            HashSet<string> secondSet = new HashSet<string>(first);

            for (int j = 0; j < second.Length; j++)
            {
                string item = second[j];
                if (secondSet.Contains(item) && item != "")
                {
                    if (temp == 0)
                    {
                        temp = 1;
                    }
                    else
                    {
                        temp *= 2;
                    }

                }

            }
            result += temp;
        }

        return result;
    }

    public void CalculatePartTwo(string[] data)
    {
        Dictionary<string, string> matchingCardsCount = new Dictionary<string, string>();

        int[][][] dataArr =  ConvertDataToArray(data);

        Console.WriteLine(String.Join(" ", dataArr[0][0]));
        Console.WriteLine(String.Join(" ", dataArr[0][1]));
    }

    public int[][][] ConvertDataToArray(string[] data)
    {
            int[][][] result = new int[data.Length][][];

            for (int i = 0; i < data.Length; i++)
            {
                var res = data[i].Split(new string[] { " | " }, StringSplitOptions.None);
                string[] firstPart = res[0].Split(':');
                string[] firstNumbers = firstPart[1].Trim().Split(' ');
                string[] secondNumbers = res[1].Trim().Split(' ');

                int[] first = new int[firstNumbers.Length];
                int[] second = new int[secondNumbers.Length];

                for (int j = 0; j < firstNumbers.Length; j++)
                {
                    if (firstNumbers[j] != "")
                    {
                        first[j] = int.Parse(firstNumbers[j]);
                    }
                }

                for (int j = 0; j < secondNumbers.Length; j++)
                {
                    if (secondNumbers[j] != "")
                    {
                        second[j] = int.Parse(secondNumbers[j]);
                    }
                }

                result[i] = new int[][] { first, second };
            }

            return result;
    }


}
