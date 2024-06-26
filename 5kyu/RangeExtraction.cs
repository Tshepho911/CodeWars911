/*A format for expressing an ordered list of integers is to use a comma separated list of either

individual integers
or a range of integers denoted by the starting integer separated from the end integer in the range by a dash, '-'. The range includes all integers i
n the interval including both endpoints. It is not considered a range unless it spans at least 3 numbers. For example "12,13,15-17"
Complete the solution so that it takes a list of integers in increasing order and returns a correctly formatted string in the range format.

Example:

solution([-10, -9, -8, -6, -3, -2, -1, 0, 1, 3, 4, 5, 7, 8, 9, 10, 11, 14, 15, 17, 18, 19, 20]);
// returns "-10--8,-6,-3-1,3-5,7-11,14,15,17-20"


*/



namespace CodeWars._5kyu
{
	public class RangeExtraction
	{
		static int[] orderedList = new int[] { -10, -9, -8, -6, -3, -2, -1, 0, 1, 3, 4, 5, 7, 8, 9, 10, 11, 14, 15, 17, 18, 19, 20 };
		static int thm = orderedList[0];
		static int last = orderedList.Length - 1;
		static int k = 0, l = 1;
		static string mystr = "";
		static string range = "";

		public static string Extract(int[] args)
		{
			if (orderedList[1] - orderedList[0] > 1)
			{
				thm = orderedList[1];
				k++; l++;
				mystr += $"{orderedList[0]}";
				Extraction();
			}
			else if (orderedList[1] - orderedList[0] == 1)
			{
				thm = orderedList[0];
				Extraction();
			}
			else
			{
				return "not ordered List";
			}


			return mystr;  //TODO
		}

		public static string Extraction()
		{
			for (int i = 1; i <= last; i++)
			{
				if (orderedList[l] - orderedList[k] > 1)
				{
				//	thm = orderedList[l];
					if (orderedList[k] - thm > 1)
					{
						range = $",s{thm}-{orderedList[k]}";
					}
					else
					{
						range = $",{thm}i";
						mystr += $"{range}";
					}
					thm = orderedList[l];

				}
				else 
				{
					if (last == l && thm == orderedList[k])
					{
						range = $", {thm},{orderedList[k]}end";
					}
					else
					{
						range = $",p{thm}-{orderedList[k]}";
					}
				}
				k++; l++;
				
			}

			return mystr;
		}
	}
}