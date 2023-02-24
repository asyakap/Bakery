using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  public class Bread
  {
     public static int BreadSum(int count)
    {
      int sum = 0;
      sum = count * 5 - 5 * (count / 3);
      return sum;
    }
  }
}