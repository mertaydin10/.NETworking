using System.Collections;
using System.Text;
using ConsoleApp1;

namespace ConsoleApp1;
class Program
{
    public static void Main(string[] args)
    {
        Counter.Increment();
        Counter.Increment();
        //Counter.Count = 5;

        System.Console.WriteLine(Counter.Count);
       
        
    }
}