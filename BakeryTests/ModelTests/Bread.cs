using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System.Collections.Generic;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests 
  {
    [TestMethod]
    public void Bread_ReturnsCorrectSum_BreadSum()
    {
      int count = 7;
      int sum = Bread.BreadSum(count);
      Assert.AreEqual(25, sum);
    }

    
  }
}