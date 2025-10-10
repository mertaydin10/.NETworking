using System.Collections;
using System.Text;
using ConsoleApp1;


class Program
{
    public static void Main(string[] args)
    {
        Person person = new Person();
        person.setName("John Doe");

        System.Console.WriteLine(person.getName());

    
    }
}