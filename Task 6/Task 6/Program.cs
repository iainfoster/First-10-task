using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter the number of the radius to get the Perimeter/Area:");
            double num = double.Parse(Console.ReadLine());
            double num1 = 3.14;
            Console.WriteLine($"Perimeter = {2 * num * num1}");
            Console.WriteLine($"Area = {num*num * num1}");
            Console.ReadKey();



        }
    }
}
