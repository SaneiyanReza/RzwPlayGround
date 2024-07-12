namespace KidsWithCandies
{
    public class KidsWithCandies
    {
        // first solution

        public static bool[] KidsWithGreatestCandies(int[] candies, int extraCandies)

        {
            int[] newCandies = new int[candies.Length];
            bool[] results = new bool[candies.Length];
            int max = default;

            for (int i = 0; i < candies.Length; i++)
            {
                if (candies[i] >= max)
                {
                    max = candies[i];
                }
                newCandies[i] = candies[i] + extraCandies;
            }
            for (int i = 0; i < newCandies.Length; i++)
            {
                if (newCandies[i] >= max)
                {
                    results[i] = true;
                }
            }

            return results;
        }
    }
}