namespace RomanToInteger
{
    public class RomanToInteger
    {
        public static int RomanToInt(string s)
        {
            Dictionary<string, string> dictionary = new()
            {
                ["I"] = "1",
                ["V"] = "5",
                ["X"] = "10",
                ["L"] = "50",
                ["C"] = "100",
                ["D"] = "500",
                ["M"] = "1000"
            };

            List<int> results = dictionary.Aggregate(s, (current, item) =>
            current.Replace(item.Key, $"{item.Value},"))
                .Split(",")
                .Where(x => !string.IsNullOrEmpty(x))
                .Select(int.Parse).ToList();

            for (int i = 0; i < results.Count; i++)
            {
                if (i == results.Count - 1)
                    break;

                if ((results[i] == 1 || results[i] == 10 || results[i] == 100) &&
                ((results[i + 1] == results[i] * 10) || results[i + 1] == results[i] * 5))
                {
                    results[i] = results[i + 1] - results[i];
                    results.RemoveAt(i + 1);
                }
            }

            return results.Sum();
        }
    }
}