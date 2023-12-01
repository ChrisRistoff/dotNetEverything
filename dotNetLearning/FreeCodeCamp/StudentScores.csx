Dictionary<string, decimal> getAverageScores()
{
    int[] sophia = [ 93, 87, 98, 95, 100 ];
    int[] nicolas = [ 80, 83, 82, 88, 85 ];
    int[] zahirah = [ 84, 96, 73, 85, 79 ];
    int[] jeong = [ 93, 92, 98, 100, 97 ];

    Dictionary<string, decimal> studentsAvgScores = new Dictionary<string, decimal>();

    studentsAvgScores["Sophia"] = calculateScores(sophia);
    studentsAvgScores["Nicolas"] = calculateScores(nicolas);
    studentsAvgScores["Zahirah"] = calculateScores(zahirah);
    studentsAvgScores["Jeong"] = calculateScores(jeong);

    return studentsAvgScores;
}

decimal calculateScores(int[] scoreArray)
{
    int sum = 0;

    for (int i = 0; i < scoreArray.Length; i++)
    {
        sum += scoreArray[i];
    }

    return sum / 5m;
}

void printStudents(Dictionary<string, decimal> stundets)
{
    foreach (var kvp in stundets)
    {
        System.Console.WriteLine($"{kvp.Key} avg score:\t{kvp.Value}");
    }
}

printStudents(getAverageScores())
