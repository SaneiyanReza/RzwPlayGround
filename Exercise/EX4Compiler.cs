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

        public static void CalculateOptimizedMatrixByOpenMp(int[,] matrix, int size)
        {
            int[,] cube = new int[size, size];

            Parallel.For(0, size, i =>
            {
                for (int j = 0; j < size; j++)
                {
                    for (int k = 0; k < size; k++)
                    {
                        cube[i, j] += matrix[i, k] * matrix[k, j];
                    }
                }
            });

            //Parallel.For(0, size, i =>
            //{
            //    Parallel.For(0, size, j =>
            //    {
            //        for (int k = 0; k < size; k++)
            //        {
            //            cube[i, j] += matrix[i, k] * matrix[k, j];
            //        }
            //    });
            //});
        }

        public static void CalculateUnoptimizedMatrix(int[,] matrix, int size)
        {
            int[,] cube = new int[size, size];

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    for (int k = 0; k < size; k++)
                    {
                        cube[i, j] += matrix[i, k] * matrix[k, j];
                    }
                }
            }
        }
    }
}