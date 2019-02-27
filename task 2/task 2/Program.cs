using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter a whole number!");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("please enter a whole number!");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"The two numbers added to geather equal\n{num1+num2}");
            Console.ReadKey();
        }
    }
}
