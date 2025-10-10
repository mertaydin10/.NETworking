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
        int counter = 0;

        Car[] cars = new Car[3];

        while (counter < cars.Length)
        {
            System.Console.WriteLine("Enter car make:");
            System.Console.WriteLine("1- Automobile");
            System.Console.WriteLine("2- Motorbike");
            int selection = int.Parse(Console.ReadLine());

            if (selection == 1)
            {
                Automobile auto = new Automobile();
                System.Console.WriteLine("Brand:");
                auto.Brand = Console.ReadLine();
                System.Console.WriteLine("Model:");
                auto.Model = Console.ReadLine();
                System.Console.WriteLine("Year:");
                auto.Year = int.Parse(Console.ReadLine());
                System.Console.WriteLine("Price:");
                auto.Price = decimal.Parse(Console.ReadLine());
                System.Console.WriteLine("Number of doors:");
                auto.numberOfDoors = int.Parse(Console.ReadLine());

                cars[counter] = auto;
            }

            else if (selection == 2)
            {
                Motorbike bike = new Motorbike();
                System.Console.WriteLine("Brand:");
                bike.Brand = Console.ReadLine();
                System.Console.WriteLine("Model:");
                bike.Model = Console.ReadLine();
                System.Console.WriteLine("Year:");
                bike.Year = int.Parse(Console.ReadLine());
                System.Console.WriteLine("Price:");
                bike.Price = decimal.Parse(Console.ReadLine());
                System.Console.WriteLine("Engine size (cc):");
                bike.engineSize = double.Parse(Console.ReadLine());

                cars[counter] = bike;
            }

            else
            {

                System.Console.WriteLine("Invalid selection. Please try again.");
                continue;
            }
            counter++;
            System.Console.WriteLine("Cars entered:");

        }

        System.Console.WriteLine("Cars list:");

        foreach (var car in cars)
        {
            car.printInfo();
        System.Console.WriteLine("-------------------");
       }


    }
}