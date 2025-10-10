using System.Collections;
using System.Text;
using ConsoleApp1;

namespace ConsoleApp1;
class Program
{
    public static void Main(string[] args)
    {

        /*    Person1 person = new Person1();
            person.FirstName = "Mert";
            person.Lastname = "Aydın";
            person.Age = 23;
            System.Console.WriteLine(person.Introduce()); */

        /*  var employee = new Employee();
          employee.FirstName = "Cevat";
          employee.Lastname = "Aydın";
          employee.Age = 48;
          employee.JobTitle = "Coffee Shop Owner";
          employee.Salary = 70000m;

          System.Console.WriteLine(employee.Introduce());  */



        var student = new Student2();
        student.FirstName = "Arin";
        student.Lastname = "Aydın";
        student.Age = 10;
        student.Lessons = "Math, Science, Art";
        System.Console.WriteLine(student.Introduce() + $" I study {student.Lessons}.");

         


    }

    
}