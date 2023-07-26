using System.Numerics;

namespace SetMatrixZeroes.Tests;

[TestClass]
public class UnitTest1
{
    private readonly Class1 _test;
    public UnitTest1() 
    {
        _test = new Class1();
    }

    [TestMethod]
    public void TestMethod1()
    {
        int[][] matrix = new int[3][];
        matrix[0] = new int[] { 1, 1, 1 };
        matrix[1] = new int[] { 1, 0, 1 };
        matrix[2] = new int[] { 1, 1, 1 };

        _test.SetZeroes(matrix);

        int[][] result = new int[3][];
        result[0] = new int[] {1,0,1};
        result[1] = new int[] {0,0,0};
        result[2] = new int[] {1,0,1};

        bool isEqual = true;

        for (int i = 0; i < result.Length; i++)
        {
            if (!Enumerable.SequenceEqual(matrix[i], result[i]))
            {
                isEqual= false;
            }
        }

        Assert.IsTrue(isEqual);
    }

    [TestMethod]
    public void TestMethod2()
    {
        int[][] matrix = new int[3][];
        matrix[0] = new int[] { 0, 1, 2, 0 };
        matrix[1] = new int[] { 3, 4, 5, 2 };
        matrix[2] = new int[] { 1, 3, 1, 5 };

        _test.SetZeroes(matrix);

        int[][] result = new int[3][];
        result[0] = new int[] { 0, 0, 0, 0 };
        result[1] = new int[] { 0, 4, 5, 0 };
        result[2] = new int[] { 0, 3, 1, 0 };

        bool isEqual = true;

        for (int i = 0; i < result.Length; i++)
        {
            if (!Enumerable.SequenceEqual(matrix[i], result[i]))
            {
                isEqual = false;
            }
        }

        Assert.IsTrue(isEqual);
    }
}