package Challenges.HackerRank;
import java.util.*;
/*
import java.io.*;
import java.math.*;
import java.security.*;
import java.text.*;
import java.util.*;
import java.util.concurrent.*;
import java.util.function.*;
import java.util.regex.*;
import java.util.stream.*;
import static java.util.stream.Collectors.joining;
import static java.util.stream.Collectors.toList;
*/

public class DiagonalDifferenceClass
{
  public static int diagonalDifference(List<List<Integer>> arr)
  {
   int totalL = 0;
   int totalR = 0;
   int r = 0;
   for(int m = 0; m < arr.size(); m++)
    {
      r= arr.size() - 1 - m;
      totalL += arr.get(m).get(m);
      totalR += arr.get(m).get(r);
    }
    int diff = totalL - totalR;
    return diff < 0 ? diff * -1 : diff;
  }

  public static void implement()
  {
    //#using Arrays Class
    //Arrays.asList(1,2,3,4);
    List<List<Integer>> arr = new ArrayList<List<Integer>>();
    arr.add(List.of(1,2,3));
    arr.add(List.of(4,5,6));
    arr.add(List.of(9,8,9));
    System.out.println(diagonalDifference(arr));

    arr = new ArrayList<>();
    arr.add(List.of(11,2,4));
    arr.add(List.of(4,5,6));
    arr.add(List.of(10,8,-12));
    System.out.println(diagonalDifference(arr));  

  }

}
