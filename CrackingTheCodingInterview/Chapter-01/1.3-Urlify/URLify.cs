using System.Runtime.Intrinsics.X86;

partial class Program
{
    /*
     * Replace all spaces in a string with '%20'
     */

    #region Solution without using additional data structures
    public static string ReplaceSpaces(string str)
    {
        int trueLength  = str.Length;

        // Transforming a string into a char array
        char[] charsArray    = new char[trueLength];
        for (int i = 0; i < trueLength; i++)
        {
            charsArray[i]    = str[i];
        }

        int spaceCount  = 0;
        int indexChars  = 0;
        for (; indexChars < trueLength; indexChars++)
        {
            if (charsArray[indexChars] == ' ')
            { 
                spaceCount++; 
            }
        }

        // Calculate new string length after replacing spaces 
        int newLength = trueLength + spaceCount * 2;

        // '\0': Represents the null character, used to indicate the end of a string
        if (trueLength < charsArray.Length)
        {
            charsArray[trueLength] = '\0'; // End of array
        }

        char[] newCharsArray = new char[newLength];
        for (int i = 0; i < charsArray.Length; i++)
        {
            newCharsArray[i] = charsArray[i];
        }

        /*
            * Loop runs through a string from back to front.
            * If a blank is found, replace the space and
            * move the index back three positions.
            * If it is not a space, just move the character to the new position index.
         */
        for (int w = trueLength - 1; w >= 0; w--)
        {
            if (newCharsArray[w] == ' ')
            {
                newCharsArray[newLength - 1]    = '0';
                newCharsArray[newLength - 2]    = '2';
                newCharsArray[newLength - 3]    = '%';
                newLength                      -= 3;
            }
            else
            {
                newCharsArray[newLength - 1]    = newCharsArray[w];
                newLength--;
            }
        }

        // Concatenating array items
        string resultReplace = String.Empty;
        for (int i = 0; i < newCharsArray.Length; i++)
        {
            resultReplace += newCharsArray[i];
        }

        return resultReplace;
    }
    #endregion

    #region Solution using language features
    public static string ReplaceSpacesSimplified(string str)
    {
        string strReplace = str.Replace(" ", "%20");

        return strReplace;
    }
    #endregion
}