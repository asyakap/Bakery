using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  public class Pastry
  {
     public static int PastrySum(int count)
    {
      int sum = 0;
      sum = count * 2 - 2 * (count / 4);
      return sum;
    }
  }
}