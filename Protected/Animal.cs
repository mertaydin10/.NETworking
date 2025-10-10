using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1;

class Animal
{
    protected string? Name { get; set; }
    protected void makeNoise()
    {
        Console.WriteLine("Animal makes a noise");
    }
}