public static class Kata1
{
  public static int Solution(int value)
  {
    int sum =0;
    int a =3, b=5;
    
    for(int i =0; i< value; i++)
    {
      if(i%a == 0 || i%b==0)
      {
        sum += i;
      }
    }
    
    return sum;
       
  }
  
}