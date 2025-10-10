using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1;

abstract class Shape
{
    public abstract double Area();

    public void shapeInfo()
    {
        Console.WriteLine("This is a geometric shape");
    }
        
}