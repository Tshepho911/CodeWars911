using System;

namespace CodeWars._6kyu
{
    public class Scramblies
    {

        public static bool Scramble(string str1, string str2)
        {
            foreach (char ch in str1)
            {
                int ind = str2.Length - 1;
                while (ind != -1)
                {
                    if (ch == str2[ind])
                    {
                        str2.Remove(ind, 1);
                        break;
                    }
                    ind -= 1;
                }
            }
            if (str2.Length == 0) return true;
            else return false;
            // your code
        }

    }
}