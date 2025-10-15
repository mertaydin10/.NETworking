using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1;

class Dog3 : IAnimal, ICanrun
{
    public void MakeSound()
    {
        System.Console.WriteLine("Woof");
    }

    public void Run()
    {
        System.Console.WriteLine("Dog is running");
    }

    
}