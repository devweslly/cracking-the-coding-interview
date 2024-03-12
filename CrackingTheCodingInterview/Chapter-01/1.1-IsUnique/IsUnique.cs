public partial class Program
{
    /*
     * Check if a string has all unique characters
     */

    #region Solution using language features
    public static bool IsUnique(string str)
    {
        str = str.ToUpper();

        // If the string is greater than 128, it will necessarily contain repeated characters
        if (str.Length > 128)
            return false;

        HashSet<char> charSet = new HashSet<char>();

        for (int i = 0; i < str.Length; i++)
        {
            if (charSet.Contains(str[i]))
                return false;

            charSet.Add(str[i]);
        }

        return true;
    }
    #endregion
}