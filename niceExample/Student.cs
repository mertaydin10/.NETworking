using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1;

public class Student
{
    private string name;
    private int[] grades;
    private int gradeCount = 0;


    public string Name
    {
        get { return name; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                Console.WriteLine("Name cannot be empty.");
            }

            else
            {
                name = value;
            }
        }
    }


    public void AddGrade(int grade)
    {
        if (gradeCount < grades.Length)
        {
            if (grade >= 0 && grade <= 100)
            {
                grades[gradeCount] = grade;
                gradeCount++;
            }
            else
            {
                System.Console.WriteLine("Not 0-100 arasinda olmalidir");
            }
        }
        else
        {
            System.Console.WriteLine("Limit dolu, ekleme yapilamadi");
        }
    }

    public double Average
    {
        get
        {
            if (gradeCount == 0)
            {
                return 0;
            }
            int sum = 0;
            for (int i = 0; i < gradeCount; i++)
            {
                sum += grades[i];
            }
            return (double)sum / gradeCount;
        }
    }


    public void InitiliazeGrades(int size)
    {
        grades = new int[size];
    }

}