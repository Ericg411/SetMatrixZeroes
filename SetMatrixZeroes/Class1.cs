namespace SetMatrixZeroes;
public class Class1
{
    public List<List<int>> zeroPool = new List<List<int>>();
    public void SetZeroes(int[][] matrix)
    {
        for (int i = 0; i < matrix.Length; i++)
        {
            for (int j = 0; j < matrix[i].Length; j++)
            {
                if (matrix[i][j] == 0)
                {
                    zeroPool.Add(new List<int>() { i, j });
                }
            }
        }
        foreach (List<int> li in zeroPool)
        {
            ZeroRow(matrix, li[0]);
            ZeroColumn(matrix, li[1]);
        }
    }
    public void ZeroRow(int[][] matrix, int indexOne)
    {
        for (int i = indexOne; i == indexOne; i++)
        {
            for (int j = 0; j < matrix[i].Length; j++)
            {
                matrix[i][j] = 0;
            }
        }
    }
    public void ZeroColumn(int[][] matrix, int indexTwo)
    {
        for (int i = 0; i < matrix.Length; i++)
        {
            for (int j = indexTwo; j == indexTwo; j++)
            {
                matrix[i][j] = 0;
            }
        }
    }
}
