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
      int count = 8;
      int sum = Pastry.PastrySum(count);
      Assert.AreEqual(12, sum);
    }
   
  }
}