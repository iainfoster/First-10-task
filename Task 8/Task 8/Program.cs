using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array;
            array = new int[100];


            Random ran = new Random();
            for (int i = 1; i <= array.Length; i++)
            {
                array[i-1] = ran.Next(1000,10000);  
            }


            for (int i = 1; i <= array.Length; i++)
            {
                Console.Write(array[i-1] + " ");
                if(i%10 == 0)
                    Console.WriteLine();

            }

        }
    }
}
