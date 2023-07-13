namespace SumOf1DArray
{
    public class SumOf1DArray
    {
        public static int[] SumNumbersOfArray(int[] numbers)
        {
            int[] sumOfNumbers = new int[numbers.Length];

            sumOfNumbers[0] = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                sumOfNumbers[i] = sumOfNumbers[i - 1] + numbers[i];
            }

            return sumOfNumbers;
        }
    }
}