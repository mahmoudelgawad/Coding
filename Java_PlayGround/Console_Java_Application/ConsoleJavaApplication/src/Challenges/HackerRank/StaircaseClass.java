package Challenges.HackerRank;


public class StaircaseClass
{
  private static void staircase(int n)
  {
   
   for(int i = 0; i < n ; i++)
    {
      int spaces = n-i-1;
      int chars = i + 1;
      System.out.println(" ".repeat(spaces) + "#".repeat(chars));
    }
  }
  
  public static void implement()
  {
    int n = 6;
    staircase(n);
    
  }

}
