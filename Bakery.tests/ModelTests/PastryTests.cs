using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System.Collections.Generic;

namespace Bakery.Tests
{
  [TestClass]
  public class PastryTests 
  {
    [TestMethod]
    public void Pastry_ReturnsCorrectSum_PastrySum()
    {
      string count1 = "4";
      string count2 = "4";
      int sum = Pastry.PastrySum(count1, count2);
      Assert.AreEqual(15, sum);
    }
   
  }
}