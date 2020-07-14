using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleTracker;

namespace Tests
{
  [TestClass]
  public class TriangleTests
  {
    [TestMethod]
    public void IsTriangleEquilateral_Equilateral_True()
    {
      Triangle testEquilateral = new Triangle();
      Assert.AreEqual(true, testEquilateral.IsTriangleEquilateral(3, 3, 3));
    }
  }
}