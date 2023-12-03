public class AdventDayTwo
{
    public string[] GetData()
    {
        string filepath = "./adventOfCode/2023/day2/data.txt";
        string[] result = { "empty" };
        string[] lastItemRemoved = { "temp" };

        try
        {
            string fileContent = File.ReadAllText(filepath);
            result = fileContent.Split("\n");
            lastItemRemoved = new string[result.Length - 1];

            for (int i = 0; i < lastItemRemoved.Length; i++)
            {
                lastItemRemoved[i] = result[i];
            }
        }
        catch (IOException e)
        {
            System.Console.WriteLine("IO Exception");
            System.Console.WriteLine(e.Message);
        }

        return lastItemRemoved;
    }

    public void GetPossibleGames(string[] data)
    {
        int sum = 0;

        for (int i = 0; i < data.Length; i++)
        {
            bool validGame = true;

            string[] split = data[i].Split(":");
            split[0] = split[0].Split(" ")[1];
            int gameNumber = int.Parse(split[0].ToString());

            string[] splitCubes = split[1].Split(";");

            foreach (string play in splitCubes)
            {
                System.Console.WriteLine(play);
                Dictionary<string, int> totalDyes = new Dictionary<string, int>();
                totalDyes["red"] = 12;
                totalDyes["green"] = 13;
                totalDyes["blue"] = 14;


                string[] splitPlay = play.Split(',');

                foreach (string separateCube in splitPlay)
                {
                    string[] numberAndDye = separateCube.Trim().Split(' ');

                    string color = numberAndDye[1];
                    int quantity = int.Parse(numberAndDye[0]);

                    totalDyes[color] -= quantity;

                    if (totalDyes[color] < 0)
                    {
                        validGame = false;
                        break;
                    }
                }
            }

            if (validGame)
            {
                sum += gameNumber;
            }
        }

        System.Console.WriteLine(sum);
    }

    public void GetMinCubes(string[] data)
    {
        int sum = 0;
        foreach (string item in data)
        {
            Dictionary<string, int> totalDyes = new Dictionary<string, int>();
            totalDyes["red"] = 0;
            totalDyes["green"] = 0;
            totalDyes["blue"] = 0;

            string currentItem = item.Split(": ")[1];
            string[] separatePlays = currentItem.Split("; " );

            for (int i = 0; i < separatePlays.Length; i++)
            {
                string[] eachPlay = separatePlays[i].Split(", ");

                foreach (string sepPlay in eachPlay)
                {
                    string[] colorAndDye = sepPlay.Split(" ");
                    int dye = int.Parse(colorAndDye[0]);
                    string color = colorAndDye[1];

                    if (totalDyes[color] < dye)
                    {
                        totalDyes[color] = dye;
                    }
                }
            }

            int total = totalDyes["red"] * totalDyes["blue"] * totalDyes["green"];
            sum += total;
        }

        System.Console.WriteLine(sum);
    }
}
