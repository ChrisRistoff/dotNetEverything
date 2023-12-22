public class AdventDayFive
{
    public string[] GetData()
    {
        string filepath = "./adventOfCode/2023/day5/testData.txt";
        string[] result = {};

        try
        {
            string fileContent = File.ReadAllText(filepath);

            result = fileContent.Split("\n\n");
        }
        catch (IOException e)
        {
            System.Console.WriteLine("IO Exception");
            System.Console.WriteLine(e.Message);
        }

        return result;
    }

    public void 
}
