﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSheet1Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Enter a number ");
                int number = Convert.ToInt32(Console.ReadLine());

                if (number % 2 == 0)
                {
                    Console.WriteLine("It is a Even number");
                    Console.ReadLine();
                }

                else
                {
                    Console.WriteLine("It is a Odd number");
                    Console.ReadLine();
                }
                Console.ReadLine();

            }
        }
    }
}
