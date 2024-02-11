using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSheet1Q6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter student's name  ");
            string studentName = Console.ReadLine();

            int marks;
            do
            {
                Console.Write("Enter exam marks  ");
                while (!int.TryParse(Console.ReadLine(), out marks) || marks < 0 || marks > 100)
                {
                    Console.WriteLine("Invalid");
                }
                if (marks < 0 || marks > 100)
                {
                    Console.WriteLine("Invalid");
                }
            } while (marks < 0 || marks > 100);

            string grade;
            if (marks >= 75 && marks <= 100)
            {
                grade = "A";
            }
            else if (marks >= 60 && marks <= 74)
            {
                {
                    grade = "B";
                }
            }
            else if (marks >= 50 && marks <= 59)
            {
                grade = "C";
            }
            else if (marks >= 40 && marks <= 49)
            {
                grade = "D";
            }
            else
            {
                grade = "Fail";
            }

            Console.WriteLine($"Student Name {studentName}");
            Console.WriteLine($"Grade {grade}");
            Console.ReadLine();

        }
    }
}
