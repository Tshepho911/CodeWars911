using System;
public class Scramblies 
{
    
    public static bool Scramble(string str1, string str2) 
    {
      foreach(char ch in str1)
      {
        int ind = str2.Length-1;
        while(ind !=-1)
        {
         if(ch==str2[ind])
         {
           str2.Remove(ind,1);
           break;
         } 
          ind -= 1;
        }
      }
      if(str2.Length == 0) return true;
      else return false;
      // your code
    }


/*


        testing(Scramblies.Scramble("rkqodlw","world"), true);
        testing(Scramblies.Scramble("cedewaraaossoqqyt","codewars"),true);
        testing(Scramblies.Scramble("katas","steak"),false);
        testing(Scramblies.Scramble("scriptjavx","javascript"),false);
        testing(Scramblies.Scramble("scriptingjava","javascript"),true);
        testing(Scramblies.Scramble("scriptsjava","javascripts"),true);
        testing(Scramblies.Scramble("javscripts","javascript"),false);
        testing(Scramblies.Scramble("aabbcamaomsccdd","commas"),true);
        testing(Scramblies.Scramble("commas","commas"),true);
        testing(Scramblies.Scramble("sammoc","commas"),true);

*/

}