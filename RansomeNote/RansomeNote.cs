namespace RansomeNote
{
    public class RansomeNote
    {
        public static bool IsContainNote(string str1, string str2)
        {
            char[] characters = str2.ToCharArray();
            int numberOfIndex = default;

            for (int i = 0; i < str2.Length; i++)
            {
                numberOfIndex = str1.IndexOf(characters[i]);

                if (numberOfIndex == -1)
                {
                    return false;
                }

                str1 = str1.Remove(numberOfIndex , 1);
            }

            return true;
        }
    }
}