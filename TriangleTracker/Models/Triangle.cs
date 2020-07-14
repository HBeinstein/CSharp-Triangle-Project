namespace TriangleTracker
{
  public class Triangle
  {
    public int Side1 { get; set; }
    public int Side2 { get; set; }
    public int Side3 { get; set; }

    public Triangle(int side1, int side2, int side3)
    {
      Side1 = side1;
      Side2 = side2;
      Side3 = side3;
    }

    public bool IsTriangleEquilateral(int side1, int side2, int side3)
    {
      if (side1 == side2 && side1 == side3)
      {
        return true;
      }
        else  
      {
        return false;
      }
    }

    public bool IsTriangleIsosceles(int side1, int side2, int side3)
    {
      if (side1 == side2 || side1 == side3 || side2 == side3)
      {
        return true;
      }
        else  
      {
        return false;
      }
    }

    public bool IsTriangleScalene(int side1, int side2, int side3)
    {
      if (side1 != side2 && side1 != side3 && side2 != side3)
      {
        return true;
      }
        else  
      {
        return false;
      }
    }

    public bool IsNotTriangle(int side1, int side2, int side3)
    {
      if (((side1 + side2) < side3) || ((side2 + side3) < side1) || ((side3 + side1) < side2))
      {
        return true;
      }
        else
      {
        return false;
      }  
    }

      public string WhatTypeTriangle(int side1, int side2, int side3)
    {
      if (IsNotTriangle(side1, side2, side3))
      {
        return "not a triangle";
      }
      else if (IsTriangleEquilateral(side1, side2, side3))
      {
        return "equilateral";
      }
      else if (IsTriangleIsosceles(side1, side2, side3))
      {
        return "isosceles";
      }
      else
      {
        return "scalene";
      }
    }  
  }  
}