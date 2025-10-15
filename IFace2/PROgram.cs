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

        IAnimal dog = new Dog3();
        IAnimal cat = new Cat3();
        ICanrun person = new Person4();

        dog.MakeSound();
        cat.MakeSound();
        person.Run();

    }


}

