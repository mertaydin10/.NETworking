using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1;

internal class Rectangle : Shape
{
    public double Genişlik { get; set; }

    public double Uzunluk { get; set; }
    public override double Area()
    {
        return Genişlik * Uzunluk;
    }
}