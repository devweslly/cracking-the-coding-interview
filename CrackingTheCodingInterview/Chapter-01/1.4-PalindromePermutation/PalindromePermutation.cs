using System;

public partial class Program
{
    /*
     * Check if a string is a permutation of a palindrome
     */

    #region Solution #1
    public static bool IsPermutationOfPalindrome(string phrase)
    {
        phrase          = phrase.ToLower();

        // Counting the frequency of a word
        int[] table     = BuildCharFrequencyTable(phrase);

        // Check that there is no more than one odd-count character
        bool checkOdd   = checkMaxOneOdd(table);

        return checkOdd;
    }
        
    private static int[] BuildCharFrequencyTable(string phrase)
    {
        // creates an array with size equal to the difference between the Unicode values of the characters 'z' and 'a' + 1
        // So that the array has space to store the frequency of all lowercase characters in the English alphabet
        int[] table     = new int[(int)'z' - (int)'a' + 1];

        foreach (char caracter in phrase)
        {
            // returns the index of the character in the table table
            int caractereCount = GetCharNumber(caracter);

            // Frequency update
            if (caractereCount != -1)
                table[caractereCount]++;
        }

        return table;
    }

    private static bool checkMaxOneOdd(int[] table)
    {
        bool foundOdd = false;

        foreach (int count in table)
        {
            if (count % 2 == 1)
            {
                if (foundOdd)
                    return false;
                
                foundOdd = true;
            }
        }

        return true;
    }
    #endregion

    #region Solução #2
    public static bool IsPermutationOfPalindromeSolution2(string phrase)
    {
        phrase          = phrase.ToLower();
        int countOdd    = 0;

        int[] table     = new int[(int)'z' - (int)'a' + 1];

        foreach (char caracter in phrase)
        {
            int value   = GetCharNumber(caracter);

            if (value != -1)
            {
                table[value]++;

                if (table[value] % 2 == 1)
                    countOdd++;
                else
                    countOdd--;
            }
        }

        return countOdd <= 1;
    }
    #endregion

    private static int GetCharNumber(char caracter)
    {
        // Stores the numeric value of the character
        int aValue  = (int)'a';
        int zValue  = (int)'z';
        int value   = (int)caracter;

        // Check whether the character's numeric value is within the range of
        // lowercase characters in the English alphabet
        if (aValue <= value && value <= zValue)
            return value - aValue;

        // Non-alphabetic characters are mapped to -1
        return -1;
    }
}