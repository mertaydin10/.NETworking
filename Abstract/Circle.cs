using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1;

internal class Circle : Shape
{
    public double Yaricap { get; set; }


    public override double Area()
    {
        return Math.PI * Yaricap * Yaricap;
    }
    
}