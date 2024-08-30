/*Return the number (count) of vowels in the given string.

We will consider a, e, i, o, u as vowels for this Kata (but not y).

The input string will only consist of lower case letters and/or spaces.
*/

/*    Best Practice example

using System;
using System.Linq;

public static class Kata
{
    public static int GetVowelCount(string str)
    {
        return str.Count(i => "aeiou".Contains(i));
    }
}*/



/*     my solution             */


using System;
using System.Linq;


namespace CodeWars
{
    public static class VowelCount
    {
        public static int GetVowelCount(string str)
        {
            int vowelCount = 0;

            foreach (char vw in str) {
                if (vw == 'a' || vw == 'e' || vw == 'i' || vw == 'o' || vw == 'u')
                    vowelCount += 1;
            }

            return vowelCount;
        }
    }

}