public class AdventDayThree
{
    public string[] GetData()
    {
        string filepath = "./adventOfCode/2023/day3/data.txt";
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
                        // Check adjacent symbols for the current number
                        bool isAdjacentToSymbol = false;
                        int numStart = j - currNum.Length;
                        int numEnd = j - 1;

                        // Check in the current, previous, and next lines
                        for (int k = numStart; k <= numEnd; k++)
                        {
                            if (IsAdjacentToSymbol(data, i, k))
                            {
                                isAdjacentToSymbol = true;
                                break;
                            }
                        }

                        if (isAdjacentToSymbol)
                        {
                            sum += int.Parse(currNum);
                        }
                        currNum = "";
                    }
                }
            }

            if (!string.IsNullOrEmpty(currNum) && IsAdjacentToSymbol(data, i, currLine.Length - currNum.Length))
            {
                sum += int.Parse(currNum);
                currNum = "";
            }
        }

        System.Console.WriteLine(sum);
    }

    private bool IsAdjacentToSymbol(string[] data, int line, int index)
    {
        HashSet<char> symbols = new HashSet<char>{'@', '#', '$', '%', '&', '*', '/', '+', '-', '='};
        // Check the current, previous, and next lines
        for (int i = -1; i <= 1; i++)
        {
            int checkLine = line + i;

            if (checkLine < 0)
            {
                checkLine = 0;
            }

            if (checkLine >= data.Length)
            {
                checkLine = data.Length-1;
            }

            // Check the left, right, and current positions
            for (int j = -1; j <= 1; j++)
            {
                int checkIndex = index + j;
                if (checkIndex < 0 || checkIndex >= data[checkLine].Length) continue;

                char checkChar = data[checkLine][checkIndex];
                if (symbols.Contains(checkChar))
                {
                    return true;
                }
            }
        }
        return false;
    }

}
