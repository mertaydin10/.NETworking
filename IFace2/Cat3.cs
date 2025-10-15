using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1;

class Cat3 : IAnimal, ICanrun
{
    public void MakeSound()
    {
        System.Console.WriteLine("Meow");
    }

    public void Run()
    {
        System.Console.WriteLine("Cat is running");
    }

    
}