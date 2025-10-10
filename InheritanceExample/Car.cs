using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1;

class Car
{
    public string? Brand { get; set; }

    public string? Model { get; set; }

    public int Year { get; set; }
    public decimal Price { get; set; }   


    public void printInfo()
    {
        Console.WriteLine($"Brand: {Brand}, Model: {Model}, Year: {Year}, Price: {Price}");
    }




}