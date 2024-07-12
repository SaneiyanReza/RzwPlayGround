namespace CountOddNumbers
{
    public class CountOddNumbers
    {
        //first solution
        //public static int CountOdds(int low, int high)
        //{
        //    int countOfOdd = default;

        //    for (; low <= high; low++)
        //    {
        //        if (low % 2 == 1)
        //            countOfOdd++;
        //    }

        //    return countOfOdd;
        //}

        //socond solution
        //public static int CountOdds(int low, int high)
        //{
        //    int countOfOdd = default;

        //    while (low <= high)
        //    {
        //        if (low % 2 == 1)
        //        {
        //            countOfOdd++;
        //        }

        //        low++;
        //    }

        //    return countOfOdd;
        //}

        //third solution
        public static int CountOdds(int low, int high)
        {
            if (low % 2 == 0 && high % 2 == 0)
            {
                return (high - low) / 2;
            }

            return ((high - low) / 2) + 1;
        }
    }
}