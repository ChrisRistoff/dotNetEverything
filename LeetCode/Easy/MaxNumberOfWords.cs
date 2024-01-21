public class MaxNumberOfWordsSolution{
    public int CanBeTypedWords(string text, string brokenLetters)
    {
        string[] wordsArr = text.Split(" ");

        int validWrods = 0;
        bool containsBrokenLetter = false;
        for (int i = 0; i < wordsArr.Length; i++)
        {
            foreach (char letter in brokenLetters)
            {
                if (wordsArr[i].Contains(letter))
                {
                    containsBrokenLetter = true;
                    break;
                }
            }

            if (!containsBrokenLetter)
            {
                validWrods++;
            }

            containsBrokenLetter = false;
        }

        return validWrods;
    }
}
