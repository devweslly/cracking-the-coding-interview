using System;

public partial class Program
{
    /*
     * Se um elemento em uma matriz MxN for 0, toda a sua linha e coluna serão definidas como 0
     */

    #region Solution 1
    public static int[][] SetZeros(int[][] matrix)
    {
        bool[] row      = new bool[matrix.Length];
        bool[] column   = new bool[matrix[0].Length];

        // Store the row and column index with value 0
        for (int i = 0; i < matrix.Length; i++)
        {
            for (int j = 0; j < matrix[0].Length; j++)
            {
                if (matrix[i][j] == 0)
                {
                    row[i]      = true;
                    column[j]   = true;
                }
            }
        }

        // Nullify rows
        for (int i = 0; i < row.Length; i++)
        {
            if (row[i])
                NullifyRow(matrix, i);
        }

        // Nullify columns
        for (int j = 0; j < column.Length; j++)
        {
            if (column[j])
                NullifyColumn(matrix, j);
        }

        void NullifyRow(int[][] matrix, int row)
        {
            for (int j = 0; j < matrix[0].Length; j++)
            {
                matrix[row][j] = 0;
            }
        }

        void NullifyColumn(int[][] matrix, int col)
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i][col] = 0;
            }
        }

        return matrix;
    }
    #endregion

    #region Solution 2

    #endregion
}