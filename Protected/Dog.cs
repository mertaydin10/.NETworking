using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1;
 class Dog : Animal
{
    public void Bark()
    {
          Name = "mhy";
          System.Console.WriteLine("Köpeğin adı: " + Name);
          makeNoise();
          Console.WriteLine("Hav hav"); 

       

    }
}