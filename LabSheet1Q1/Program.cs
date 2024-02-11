using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSheet1Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PLease enter the length");
            int h =
            Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("PLease enter the width");
            int w =
            Convert.ToInt32(Console.ReadLine());

            CalArea(w, h);
            Console.ReadLine();
        }

        static void CalArea(int length, int height)
        {
            int area;
            area = height * length;
            Console.WriteLine("The area is" + area);
        }
    }
}
