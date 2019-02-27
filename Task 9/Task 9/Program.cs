using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int caseSwitch = 1;

            switch (caseSwitch)
            {
                case 1:
                    Console.WriteLine("question 1");
                    Console.WriteLine(Q1());
                    break;
                case 2:
                    Console.WriteLine("question 2");
                    Console.WriteLine(Q2());
                    break;
                case 3:
                    Console.WriteLine("question 3");
                    Console.WriteLine(Q3());
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }


            {
                int num1 = 10, num2 = 20, temp;
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

            int[] array;
            array = new int[100];


            Random ran = new Random();
            for (int i = 1; i <= array.Length; i++)
            {
                array[i - 1] = ran.Next(1000, 10000);
            }


            for (int i = 1; i <= array.Length; i++)
            {
                Console.Write(array[i - 1] + " ");
                if (i % 10 == 0)
                    Console.WriteLine();

            }
        }

        static double Q1()
        {
            
                Console.WriteLine("please enter the number of the radius to get the Perimeter/Area:");
                double num = double.Parse(Console.ReadLine());
                double num1 = 3.14;
            double result = num * num * num1;
                Console.WriteLine($"Perimeter = {2 * num * num1}");
                Console.WriteLine($"Area = {result}");
                Console.ReadKey();

            return result;
        }

        static int[] Populate()
        {

            return
        }
    }
}
