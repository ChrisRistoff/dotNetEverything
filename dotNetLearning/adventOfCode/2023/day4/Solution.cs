public class AdventDayFour
{
    public string[] GetData()
    {
        string filepath = "./adventOfCode/2023/day4/testData.txt";
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

    public int Calculate(string[] data)
    {
        int result = 0;
        for (int i = 0; i < data.Length; i++)
        {
            int temp = 0;
            var res = data[i].Split(":");
            res = res[1].Split("|");
            Console.WriteLine("First: " + res[0]);
            Console.WriteLine("Second: " + res[1]);

            string[] first = res[0].Trim().Split(" ");
            string[] second = res[1].Trim().Split(" ");

            HashSet<string> firstSet = new HashSet<string>(first);

            foreach (string item in second)
            {
                Console.WriteLine("Checking: " + item);
                if (item != " " && firstSet.Contains(item))
                {
                    Console.WriteLine("Found a match: " + item);
                    if (temp == 0)
                    {
                        temp++;
                    }
                    else
                    {
                        temp *= 2;
                        break;
                    }

                }
            }

            result += temp;
        }

        return result;
    }
}
