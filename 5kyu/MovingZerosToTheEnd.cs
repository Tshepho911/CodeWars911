/*

Write an algorithm that takes an array and moves all of the zeros to the end, preserving the order of the other elements.

Kata.MoveZeroes(new int[] {1, 2, 0, 1, 0, 1, 0, 3, 0, 1}) => new int[] {1, 2, 1, 1, 3, 1, 0, 0, 0, 0}


*/
namespace CodeWars._5kyu
{
	public class MoveZeros
	{
	  public int[] MoveZeroes(int[] arr)
	  {
		// TODO: Program me
		int s = arr.Length;
		int lz= s-1;
		int f = 0;
		int[] orderZeros = new int[s];
		int[] orderedNumbers = new int [s]; 
		
		
		for (int i =0; i<s; i++)
		{
			if(arr[i] == 0)
			{
				orderZeros[lz] = 0;
				lz--;
			}
		}
		
		for (int l =0; l< s; l++)
		{
			if(arr[l] != 0)
			{
				orderZeros[f] = arr[l];
				f++;
			}
			
		}
		
		return orderZeros;
	  }
	}
}