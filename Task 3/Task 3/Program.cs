using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a whole number");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a whole number");
            double num2 = double.Parse(Console.ReadLine());
            Console.WriteLine($"The numbers number divided together = {num1 / num2}");
            Console.ReadKey();
        }
    }
}
