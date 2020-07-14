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

    [TestMethod]
    public void IsTriangleIsosceles_Isosceles_True()
    {
      Triangle testIsosceles = new Triangle();
      Assert.AreEqual(true, testIsosceles.IsTriangleIsosceles(3, 3, 2));
    }

    [TestMethod]
    public void IsTriangleScalene_Scalene_True()
    {
      Triangle testScalene = new Triangle();
      Assert.AreEqual(true, testScalene.IsTriangleScalene(1, 2, 3));
    }
  }
}