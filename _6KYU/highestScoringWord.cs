/*using System.Linq;
using System;

public class Kata
{
  public static string High(string s)
  {
    return s.Split(' ').OrderBy(a => a.Select(b => b - 96).Sum()).Last();
  }
}

*/

namespace CodeWars._6KYU
{
    public class Kata
    {
        public static int CalculateScore(string lStr)
        {
            string alpha = " abcdefghijklmnopqrstuvwxyz";
            int myscore = 0;
            foreach (char ch in lStr)
            {
                for (int l = 1; l < alpha.Length; l++)
                {
                    if (alpha[l] == ch)
                    {
                        myscore += l;
                    }
                }
            }
            return myscore;

        }

        public static string EarlyString(string curHigh, string newHigh)
        {
            for (int l = 0; l < curHigh.Length; l++)
            {
                if (curHigh[l] > newHigh[l])
                {
                    return newHigh;
                }
                if (curHigh[l] < newHigh[l])
                {
                    return curHigh;
                }
            }
            return curHigh;
        }


        public static string High(string s)
        {
            string alpha = " abcdefghijklmnopqrstuvwxyz";
            string[] arrayStr = s.Split(' ');
            int highScore = 0;
            string highString = "";
            foreach (string str in arrayStr)
            {

                int sc = CalculateScore(str);
                if (sc > highScore)
                {
                    highScore = sc;
                    highString = str;
                }
                /*if(sc==highScore)
                {
                  highScore =sc;
                  highString = EarlyString(highString, str);

                }*/
            }
            return highString;
        }

    }
}