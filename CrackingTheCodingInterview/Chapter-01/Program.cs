using System;
public partial class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Solutions for arrays and strings");

        #region 1.1 Is Unique
        string isUnique = IsUnique("Weslly") ? "A string has unique characters" : "A string has no unique characters";
        Console.WriteLine(isUnique);
        #endregion

        #region 1.2 Check Permutation
        string isPermutation = IsPermutation("adaddgggeeee", "ddadegeggecc") ? "Strings are a permutation" : "Strings are not a permutation";
        Console.WriteLine(isPermutation);
        isPermutation = IsPermutationUsingDict("adaddgggeeee", "ddadegegegcc") ? "Strings are a permutation" : "Strings are not a permutation";
        Console.WriteLine(isPermutation);
        #endregion

        #region 1.3 URLify
        string replaceSpaces = ReplaceSpaces("Mr John Smith");
        Console.WriteLine(replaceSpaces);
        string replaceSimplified = ReplaceSpacesSimplified("Mr John Smith");
        Console.WriteLine(replaceSimplified);
        #endregion

        #region 1.4 Palindrome Permutation
        string phrase = "Tact Coa";
        Console.WriteLine($"{phrase} is permutation of palindrome: {IsPermutationOfPalindrome(phrase)}");
        Console.WriteLine($"{phrase} is permutation of palindrome: {IsPermutationOfPalindromeSolution2(phrase)}");
        #endregion

        #region 1.5 One Away
        Console.WriteLine($"Strings are an edit away: {OneEditAway("pale", "dale")}");
        Console.WriteLine($"Strings are an edit away: {OneEditAwaySolution2("pale", "dale")}");
        #endregion

        #region 1.6 String Compression
        //string str = "aabcccccaaa";
        //Console.WriteLine($"A compactação da string '{str}': '{CompressBad(str)}'");
        //Console.WriteLine($"A compactação da string '{str}': '{Compress(str)}'");
        //Console.WriteLine($"A compactação da string '{str}': '{CompressSolution3(str)}'");
        #endregion

        #region 1.7 Rotate Matrix
        /*
        // Declara uma matriz de 3 linhas e 3 colunas
        int[][] matrix = new int[3][];

        // Inicializar cada linha da matriz
        for (int i = 0; i < matrix.Length; i++)
        {
            matrix[i] = new int[3];
        }

        // Método para preencher a matriz com valores de exemplo
        int counter = 1;
        for (int i = 0; i < matrix.Length; i++)
        {
            for (int j = 0; j < matrix[i].Length; j++)
            {
                matrix[i][j] = counter;
                counter++;
            }
        }

        Console.WriteLine();
        Console.WriteLine("A matriz");
        Console.WriteLine();
        
        // Imprime a matriz
        for (int i = 0; i < matrix.Length; i++)
        {
            for (int j = 0; j < matrix[i].Length; j++)
            {
                Console.Write(matrix[i][j] + "\t");
            }
            Console.WriteLine();
        }

        int[][] matrixRotate = rotate(matrix);

        if (matrixRotate == null)
            Console.WriteLine("A matriz tem tamanho zero");

        Console.WriteLine();
        Console.WriteLine("A matriz rotacionada em 90 graus");
        Console.WriteLine();

        // Imprime a matriz rotacionada
        for (int i = 0; i < matrixRotate.Length; i++)
        {
            for (int j = 0; j < matrixRotate[i].Length; j++)
            {
                Console.Write(matrixRotate[i][j] + "\t");
            }
            Console.WriteLine();
        }
        */
        #endregion

        #region 1.8 Rotate Matrix
        /*
        // Declara uma matriz de 3 linhas e 3 colunas
        int[][] matrixZero = new int[3][];

        // Inicializar cada linha da matriz
        for (int i = 0; i < matrixZero.Length; i++)
        {
            matrixZero[i] = new int[3];
        }

        // Método para preencher a matriz com valores de exemplo
        int count = 1;
        for (int i = 0; i < matrixZero.Length; i++)
        {
            for (int j = 0; j < matrixZero[i].Length; j++)
            {
                matrixZero[i][j] = count;
                count++;
            }
        }

        Console.WriteLine();
        Console.WriteLine("A matriz");
        Console.WriteLine();

        // Imprime a matriz
        for (int i = 0; i < matrixZero.Length; i++)
        {
            for (int j = 0; j < matrixZero[i].Length; j++)
            {
                Console.Write(matrixZero[i][j] + "\t");
            }
            Console.WriteLine();
        }

        int[][] matrixZeroResult = SetZeros(matrixZero);

        if (matrixZeroResult == null)
            Console.WriteLine("A matriz tem tamanho zero");

        Console.WriteLine();
        Console.WriteLine("Substituindo os valores da matriz");
        Console.WriteLine();

        // Imprime a matriz rotacionada
        for (int i = 0; i < matrixZeroResult.Length; i++)
        {
            for (int j = 0; j < matrixZeroResult[i].Length; j++)
            {
                Console.Write(matrixZeroResult[i][j] + "\t");
            }
            Console.WriteLine();
        }
        */
        #endregion

        #region 1.9 String Rotation
        string[] pairs = new string[] { "apple", "pleap" };
        Console.WriteLine($"{pairs[1]} é uma rotação de {pairs[0]}: {IsRotation(pairs[0], pairs[1])}");
        #endregion
    }
}
