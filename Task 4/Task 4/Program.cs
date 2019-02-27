using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a whole number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a whole number");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"The numbers number multiplied together = {num1 * num2}");
            Console.ReadKey();
        }
    }
}
