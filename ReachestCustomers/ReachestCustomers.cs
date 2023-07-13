namespace ReachestCustomers
{
    public class ReachestCustomers
    {
        public static int GetReachestCustomer()
        {
            int[][] amounts = new int[4][];
            int[] sumOfAmount = new int[amounts.Length];

            for (int i = 0; i < amounts.Length; i++)
            {
                sumOfAmount[i] = amounts[i][i];
            }

            return 1;
        }

    }
}