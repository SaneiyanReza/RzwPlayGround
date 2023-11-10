#region SumOf1DArray Done!

//int[] numbers = { 3, 1, 2, 10, 1 };
//var result = SumOf1DArray.SumOf1DArray.SumNumbersOfArray(numbers);

#endregion

#region ReachestCustomer Done!

//int[,] cash = { { 6, 7, 8 }, { 3, 4, 5 }, { 1, 2, 3 } };
//var result = ReachestCustomers.ReachestCustomers.GetReachestCustomer(cash);

#endregion

#region RansomeNote Done!

//var result = RansomeNote.RansomeNote.IsContainNote("abcd", "cac");

#endregion

using Exercise;
using System.Diagnostics;

internal class Program
{
    private static void Main(string[] args)
    {
        int n = 1000;
        int[,] matrix = new int[n, n];

        Random random = new();
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matrix[i, j] = random.Next(1, n);
            }
        }

        Stopwatch optimizedStopwatch = new();

        optimizedStopwatch.Start();

        EX4Compiler.CalculateOptimizedMatrix();

        optimizedStopwatch.Stop();

        Console.WriteLine($"calculate Optimized Matrix: {optimizedStopwatch.Elapsed}");

        optimizedStopwatch.Restart();

        EX4Compiler.CalculateUnoptimizedMatrix(matrix, n);

        optimizedStopwatch.Stop();

        Console.WriteLine($"calculate Unoptimized Matrix: {optimizedStopwatch.Elapsed}");

        optimizedStopwatch.Restart();

        EX4Compiler.CalculateOptimizedMatrixByOpenMp(matrix, n);

        optimizedStopwatch.Stop();

        Console.WriteLine($"calculate Matrix By OpenMp: {optimizedStopwatch.Elapsed}");

        Console.ReadKey();
    }
}