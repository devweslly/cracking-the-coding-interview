public partial class Program
{
    /*
     * Realizar a rotação de uma imagem em 90 graus
     */

    public static int[][] rotate(int[][] matrix)
    {
        if (matrix.Length == 0 || matrix.Length != matrix[0].Length)
            return null;

        int len = matrix.Length;

        for (int layer = 0; layer < len / 2; layer++)
        {
            int first   = layer;
            int last    = len - 1 - layer;

            for (int i = first; i < last; i++)
            {
                int offset  = i - first;
                int top     = matrix[first][i]; // save top

                // left -> top
                matrix[first][i]                = matrix[last - offset][first];

                // bottom -> left
                matrix[last - offset][first]    = matrix[last][last - offset];

                // right -> bottom
                matrix[last][last - offset]     = matrix[i][last];

                // top -> right
                matrix[i][last]                 = top; // right<-saved top
            }
        }

        return matrix;
    }
}