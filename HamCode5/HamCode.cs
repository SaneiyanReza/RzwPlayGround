using System.Numerics;

namespace HamCode5
{
    public class HamCode
    {
        public static string ConvertDotToGolang(string stdin)
        {
            string stdout = stdin.Replace(".NET", "Golang");

            return stdout;
        }

        public static string Golangestan(string stdin)
        {
            const int maxSize = 4;

         var paddingDicts = stdin.Split(' ')
            .Select((value, index) => new { Index = index, Value = maxSize - int.Parse(value) })
            .OrderBy(x => x.Value)
            .ToDictionary(item => item.Index, item => item.Value);

        for (int i = 0; i < paddingDicts.Count; i++)
        {
            if (paddingDicts[i] > 0)
            {
                KeyValuePair<int, int> paddingMustTake = paddingDicts
                    .FirstOrDefault(x => x.Key != i && x.Value >= maxSize - paddingDicts[i]);

                if (paddingMustTake.Key == default && paddingMustTake.Value == default)
                {
                    paddingDicts[i] = 1;
                }
                else
                {
                    paddingDicts[i] = paddingDicts[paddingMustTake.Key] - paddingDicts[i];
                    paddingDicts[paddingMustTake.Key] = paddingDicts[i] < 0 ? -paddingDicts[i] : 0;
                    paddingDicts[i] = 0;
                }
            }
        }

            int lastKeyPaddingSpace = paddingDicts
                .Where(x => x.Value > 0)
                .LastOrDefault()
                .Key;

            paddingDicts.Remove(lastKeyPaddingSpace);

            string stdout = paddingDicts.Values.Sum().ToString();

            return stdout;
        }

        private static void DegradedEquation()
        {
            int stdin = int.Parse(Console.ReadLine());
            var stdouts = new string[stdin];

            for (int i = 0; i < stdin; i++)
            {
                int strLength = int.Parse(Console.ReadLine());
                string numberString = Console.ReadLine();
                stdouts[i] = CanFormEquation(numberString, strLength) ? "YES" : "NO";
            }

            foreach (string stdout in stdouts)
            {
                Console.WriteLine(stdout);
            }
        }

        private static bool CanFormEquation(string numberString, int strLength)
        {
            for (int x = 1; x <= strLength - 2; x++)
            {
                if (strLength - x - 1 < 1)
                    break;

                if (!BigInteger.TryParse(numberString.AsSpan(0, x), out var firstPart))
                    continue;

                for (int y = x + 1; y <= strLength - 1; y++)
                {
                    if (y - x < 1 || strLength - y < 1)
                        continue;

                    string secondPartStr = numberString.Substring(x, y - x);
                    string thirdPartStr = numberString.Substring(y);

                    if (BigInteger.TryParse(secondPartStr, out var secondPart) && BigInteger.TryParse(thirdPartStr, out var thirdPart))
                    {
                        if (firstPart + secondPart == thirdPart)
                        {
                            return true;
                        }
                    }
                }
            }

            return false;
        }
    }
}


//--baraye inke zekr nashode bood ghabl azmoon ba chy query zade shavad va man sql server zadam
//-- Section1
//SELECT TOP 3  sport, COUNT(medal) AS medal_count
//FROM dbo.athletes 
//WHERE team = 'Iran' 
//GROUP BY sport
//ORDER BY medal_count DESC

//-- Section2
//SELECT name, medal 
//FROM dbo.athletes
//WHERE team = 'Iran' AND event LIKE '%2016%' AND medal IS NOT NULL
//ORDER BY
//CASE
//WHEN medal = 'Gold' THEN 1
//WHEN medal = 'Silver' THEN 2
//WHEN medal = 'Bronze' THEN 3
//ELSE 4
//END
//DESC

//-- Section3


//-- Section4
//SELECT TOP 22 
//team,
//COUNT(CASE WHEN sex = 'F' THEN 1 END) AS female_medalists,
//COUNT(CASE WHEN sex = 'M' THEN 1 END) AS male_medalists,
//COUNT(CASE WHEN sex = 'F' THEN 1 END) / COUNT(CASE WHEN sex = 'M' THEN 1 END) AS female_to_male_ratio
//FROM dbo.athletes
//WHERE medal IS NOT NULL 
//GROUP BY team


