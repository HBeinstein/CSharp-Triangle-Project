using System;
using System.Collections.Generic;
using TriangleTracker;

namespace TriangleProject
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Enter Side One");
      int side1 = int.Parse(Console.ReadLine());
      
      Console.WriteLine("Enter Side Two");
      int side2 = int.Parse(Console.ReadLine());

      Console.WriteLine("Enter Side Three");
      int side3 = int.Parse(Console.ReadLine());

      Triangle triangleType = new Triangle(side1, side2, side3);
      string triangleName = triangleType.WhatTypeTriangle(side1, side2, side3);
      Console.WriteLine(triangleName);
    }
  }
}