using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a whole number");
           
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine("Multiplication table");
            for(int i = 1; i<=10;i++)
            {
                Console.WriteLine($"{num} x {i}= {i*num}");
            }
        }
    }
}
