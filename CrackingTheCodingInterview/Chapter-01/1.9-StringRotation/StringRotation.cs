public partial class Program
{
    /*
     * Verificar se s2 é uma rotação de s1
     */

    public static bool IsRotation(string strOne, string strTwo)
    {
        int lenStrOne = strOne.Length;

        // Check that sl and s2 are equal length and not empty
        if (strTwo.Length == lenStrOne && lenStrOne >= 0)
        {
            string s1s1 = strOne + strOne;
            
            return IsSubstring(s1s1, strTwo);
        }

        return false;
    }

    public static bool IsSubstring(string big, string small)
    {
        return big.IndexOf(small, StringComparison.CurrentCultureIgnoreCase) >= 0;
    }
}