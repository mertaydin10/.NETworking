using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Text;
using ConsoleApp1;

namespace ConsoleApp1;

class Program
{
    public static void Main(string[] args)
    {
        Shape rectangle = new Rectangle{Genişlik=5, Uzunluk=10};
       System.Console.WriteLine("Rectangel is area = " + rectangle.Area()); 

        Shape circle = new Circle{Yaricap=7};
        System.Console.WriteLine("Circle is area = " + circle.Area());
        
        


    }
    

}