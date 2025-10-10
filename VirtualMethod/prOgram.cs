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

        Animal1 animal = new Animal1();
        animal.makeSound();

        Animal1 cat = new Cat();
        cat.makeSound();

        Animal1 dog = new Dog2();
        dog.makeSound();


    }
    

}