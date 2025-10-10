using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1;

public class Settinggs
{
    public static string AppName { get; set; }

   static Settinggs()
    {
        AppName = "Sağlık Randevu Sistemi";
        System.Console.WriteLine("Static constructor called");
    }


}