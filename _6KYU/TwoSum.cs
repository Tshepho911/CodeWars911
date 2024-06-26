

public class TwoSum1
{
  public static int[] TwoSum(int[] numbers, int target)
  {
    int [] retArray = new int[2];
    for(int l=0; l<numbers.Length; l++)
    {
        for(int n=0; n<numbers.Length; n++)
        {
          if(numbers[l]+numbers[n]==target  && l!=n){            
             retArray[0]=l;
             retArray[1]=n;
           //  retArray.Add(l);
            }
        }   
    }
  
    
    return retArray ;
  }
}