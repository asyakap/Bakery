using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  public class Bread
  {
     public static int BreadSum(string count1, string count2, string count3)
    {
      int baguette = Int32.Parse(count1);
      int white = Int32.Parse(count2);
      int black = Int32.Parse(count3);
      int total = baguette + white + black;
      int sum = 0;
      sum = baguette * 3 - 3 * (baguette / 3) + white * 4 - 4 * (white / 3) + black * 5 - 5 * (black / 3);
      return sum;
    }
  }
}