namespace ReachestCustomers
{
    public class ReachestCustomers
    {
        public static int GetReachestCustomer(int[,] amounts)
        {
            int max = 0;

            for (int i = 0; i < amounts.GetLength(0); i++)
            {
                int sumOfAmount = 0;
                for (int j = 0; j < amounts.GetLength(1); j++)
                {
                    sumOfAmount += amounts[i, j];
                }

                max = sumOfAmount > max ? sumOfAmount : max;
            }

            return max;
        }
    }
}