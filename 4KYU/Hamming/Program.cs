/*
DESCRIPTION:
A Hamming number is a positive integer of the form 2i3j5k, for some non-negative integers i, j, and k.

Write a function that computes the nth smallest Hamming number.

Specifically:

The first smallest Hamming number is 1 = 203050
The second smallest Hamming number is 2 = 213050
The third smallest Hamming number is 3 = 203150
The fourth smallest Hamming number is 4 = 223050
The fifth smallest Hamming number is 5 = 203051
The 20 smallest Hamming numbers are given in the Example test fixture.

Your code should be able to compute the first 5 000 ( LC: 400, Clojure: 2 000, Haskell: 12 691, NASM, C, D, C++, Go and Rust: 13 282 ) Hamming numbers without timing out.







// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int jump =0;
int l = 1;
int index = 20;
int value1 = 1;
int value = 1;
Console.WriteLine($"************The smallest {index}th of the form 2^i*3^j*^5^k is== {Compute(index)} *************");

*/

long Compute(int index) 
{
	for (int i = 1; i <= index;  i++) 
	{
		//value = DivideBy5(i);
		
	//	value1 = 1;


		
		int temp = 0;
		do
		{
			value1 = 1;
			temp = DivideBy5(l);
		//	Console.WriteLine($"tempdo-while***********the {i}th smallest term is:= {value} \n");
			l++;
		} while (temp == -1);

		value = temp;
		Console.WriteLine($"the {i}th smallest term is:= {value} \n");

	}
	return value	;
		
}



int DivideBy5(int n)
{
	int ite = 0, Rem = n, Quo=n, ans=0  ;
	do
	{
		
	
			Rem = Quo % 5;
			//	Quo = Quo / 5;


			if (Rem == 0)
			{
				ite++;
				value1 *= 5;
				Quo = Quo / 5;
				//	Rem = Quo;
			}
			else if (Quo == 0 && Rem == 1) { return value1; }
			else
			{
				ans = DivideBy3(Quo);
				if (ans < 0) 
				{	jump++;
					Quo =n+ jump;
				}

			}
	
	} while (Rem == 0);
//	Console.WriteLine($"5exp({ite}) the th smallest term is:= {value1} ");
	return value1;
}


int DivideBy3(int n)
{
	int ite = 0, Rem = n, Quo = n, ans;
	do
	{
		Rem = Quo % 3;
		


		if (Rem == 0)
		{
			ite++;
			value1 *= 3;
			Quo = Quo / 3;
			
		}
		else if (Quo == 0 && Rem == 1) { return value1; }
		else
		{
	//		Console.WriteLine($"{Quo}");
			value1 = DivideBy2(Quo);		
		}
		
	} while (Rem == 0);
//	Console.WriteLine($"3exp({ite})  --> the th smallest term is:= {value1} ");
	return value1;

}

int DivideBy2(int n)
{
	int ite = 0, Rem = n, Quo = n, ans;
	do
	{
		Rem = Quo % 2;
	//	Quo = Quo / 2;


		if (Rem == 0)
		{
			ite++;
			value1 *= 2;
			Quo = Quo / 2;
		//	Rem = Quo;
		}
		else if (Quo == 0 && Rem == 1) {
			
			return value1; }
		else if (Quo >=2  && Rem == 1)
		{

			return -1;
		}
		else
		{
		//	Console.WriteLine($"2exp({ite}) the th smallest term is:= {value1} ");
			return value1;
		}
		
	} while (Rem == 0);
	Console.WriteLine($"2exp({ite}) the th smallest term is: = {value1} ");
	//Console.WriteLine($" \n ");
	return value1;
}







