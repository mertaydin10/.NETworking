using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1;

class Car : ICar
{
    public void Start()
    {
        System.Console.WriteLine("Car started");
    }

    public void Stop()
    {
        System.Console.WriteLine("Car stopped");
    }


}