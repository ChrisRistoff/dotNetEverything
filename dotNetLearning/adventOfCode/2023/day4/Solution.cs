public class AdventDayFour
{
    public string[] GetData()
    {
        string filepath = "./adventOfCode/2023/day4/data.txt";
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
}
