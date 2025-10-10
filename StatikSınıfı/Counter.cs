using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1;

public class Counter
{
    public static int Count { get; private set; } 
    public static void Increment()
    {
        Count++;
    }
}