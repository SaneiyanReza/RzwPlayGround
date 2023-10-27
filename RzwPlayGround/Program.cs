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

// تعریف ماتریس A با اعداد صحیح
// محاسبه توان سه ماتریس A
using Exercise;
using System.Diagnostics;

internal class Program
{
    private static void Main(string[] args)
    {
        Stopwatch optimizedStopwatch = new();

        optimizedStopwatch.Start();
        EX4Compiler.CalculateOptimizedMatrix();
        optimizedStopwatch.Stop();

        Stopwatch unOptimizedStopwatch = new();

        unOptimizedStopwatch.Start();
        EX4Compiler.CalculateUnoptimizedMatrix();
        unOptimizedStopwatch.Stop();

        Console.WriteLine($"optimize elapse time : {optimizedStopwatch.Elapsed} " +
            $"unoptimize elapse time : {unOptimizedStopwatch.Elapsed}");

        Console.ReadKey();
    }
}