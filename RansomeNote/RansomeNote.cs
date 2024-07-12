namespace RansomeNote
{
    public class RansomeNote
    {
        //first solution
        //public static bool IsContainNote(string str1, string str2)
        //{
        //    int numberOfIndex = default;

        //    for (int i = 0; i < str1.Length; i++)
        //    {
        //        char indexOfStr1 = str1[i];

        //        numberOfIndex = str2.IndexOf(indexOfStr1);

        //        if (numberOfIndex == -1)
        //        {
        //            return false;
        //        }

        //        str2 = str2.Remove(numberOfIndex, 1);
        //    }

        //    return true;
        //}

        //second solution
        public static bool IsContainNote(string str1, string str2)
        {
            Dictionary<char, int> keyValuePairs = str2
                .GroupBy(x => x)
                .ToDictionary(x => x.Key, y => y.Count());

            for (int i = 0; i < str1.Length; i++)
            {
                 keyValuePairs.TryGetValue(str1[i], out int specificValueOfKey);

                if (specificValueOfKey > 0)
                {
                    keyValuePairs[str1[i]]--;

                    continue;
                }
                return false;
            }

            return true;
        }
    }
}