using System.Collections;
using System.Text;
using ConsoleApp1;


class Program
{
    public static void Main(string[] args)
    {
        Student student = new Student();

        System.Console.WriteLine("Enter student name:");
        student.Name = Console.ReadLine();

        System.Console.WriteLine("Enter number of grades:");
        int size = int.Parse(Console.ReadLine());
        student.InitiliazeGrades(size);

        System.Console.WriteLine("Enter grades (0-100):");
        for (int i = 0; i < size; i++)
        {
            System.Console.WriteLine($"Grade {i + 1}:");
            int grade = int.Parse(Console.ReadLine());
            student.AddGrade(grade);
        }

        System.Console.WriteLine($"\nStudent : {student.Name}");
        System.Console.WriteLine($"Average Grade: {student.Average}");







    }
}