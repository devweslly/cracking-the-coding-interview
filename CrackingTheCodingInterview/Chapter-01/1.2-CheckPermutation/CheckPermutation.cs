partial class Program
{
    /*
     * Check if two strings are a permutation of each other.
     */

    #region Using array
    public static bool IsPermutation(string str1, string str2)
    {
        if (str1.Length != str2.Length)
            return false;

        int[] letterCount = new int[128];
        foreach (char letter in str1)
        {
            letterCount[letter]++;
        }

        foreach (char letter in str2)
        {
            letterCount[letter]--;

            if (letterCount[letter] < 0)
                return false;
        }

        return true;
    }
    #endregion

    #region Using hash table (dictionary) instead of an array
    public static bool IsPermutationUsingDict(string str1, string str2)
    {
        if (str1.Length != str2.Length)
            return false;

        Dictionary<char, int> letterCountDict = new Dictionary<char, int>();
        foreach (char letter in str1)
        {
            if (!letterCountDict.ContainsKey(letter))
                letterCountDict.Add(letter, 1);
            else
                letterCountDict[letter]++;
        }

        foreach (char letter in str2)
        {
            if (!letterCountDict.ContainsKey(letter))
                return false;

            if (letterCountDict[letter] <= 0)
                return false;

            letterCountDict[letter]--;
        }

        return true;
    }
    #endregion
}