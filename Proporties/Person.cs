using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1 {

    public class Person
    {
        private int age;
        
        public int Age
        {
            get
            {
                if (age > 0)
                {
                    return age;
                }
                else
                {
                    return -1;
                }
             }
            set
            {
                if (value < 0)
                {
                    System.Console.WriteLine("Age cannot be negative.");
                }
                else
                {
                    age = value;
                }

                
            }
        }

     

     }
}