using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1;

public class Person1
{
    public string? FirstName { get; set; }

    public string? Lastname { get; set; }

    public byte Age { get; set; }

    /* public string FullName()
    {
        return $"{FirstName} {Lastname}";
    } */
    public string FullName() => $"{FirstName} {Lastname}";

    public string Introduce()  => $"Hello, I'm {FullName()} and I'm {Age}.";
         
    


      
}