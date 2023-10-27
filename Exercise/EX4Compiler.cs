using MathNet.Numerics.LinearAlgebra;

namespace Exercise
{
    public static class EX4Compiler
    {
        public static void CalculateOptimizedMatrix()
        {
            Random random = new();

            Matrix<double> cube = Matrix<double>.Build.Dense(1000, 1000, (i, j) => random.Next(1, 1000)).Power(3);
        }

        public static void CalculateUnoptimizedMatrix()
        {
            int n = 1000;
            int[,] matrix = new int[n, n];
            int[,] cube = new int[n, n];

            Random random = new();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = random.Next(1, 1000);
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    for (int k = 0; k < n; k++)
                    {
                        cube[i, j] += matrix[i, k] * matrix[k, j];
                    }
                }
            }
        }
    }
}