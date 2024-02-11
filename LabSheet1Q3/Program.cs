using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSheet1Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number ");
            int num = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            {
                if (num <= 0)
                {
                    Console.WriteLine("Error");
                }
                else
                {
                    for (int i = 1; i <= num; i++)
                    {
                        sum += i;
                    }
                }
            }
            Console.WriteLine("The sum all numbers " + sum);
            Console.ReadLine();

        }
    }
}
