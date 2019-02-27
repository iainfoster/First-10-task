using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 =10, num2=20, temp;
            Console.WriteLine($"\nNumber 1 equals {num1}.");
            Console.WriteLine($"\nNumber 2 equals {num2}.");
            temp = num1;
            num1 = num2;
            num2 = temp;
            Console.Write("\nAfter Swapping : ");
            Console.Write("\nFirst Number : " + num1);
            Console.WriteLine($"\nFirst Number: {num1}");
            Console.WriteLine("\nFirst Number: {0}", num1);
            Console.Write("\nSecond Number : " + num2);
            Console.Read();
        }
    }
}
