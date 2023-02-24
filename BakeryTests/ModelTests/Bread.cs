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
      string baguette = "3";
      string white = "3";
      string black = "3";
      int sum = Bread.BreadSum(baguette, white, black);
      Assert.AreEqual(24, sum);
    }
   
  }
}