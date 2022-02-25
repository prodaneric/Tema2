using System;
using System.Collections.Generic;
using System.Text;

namespace Tema2
{
    class Task2
    {
        public static void task2()
        {
            Random rnd = new Random();

            int[,] B = new int[5, 5];


            //assigning values to the array
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    B[i, j] = rnd.Next(-100, 100);
                }
            }

            //calculating the sum between even and odd numbers
            int sum_even = 0;
            int sum_odd = 0;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (B[i, j]%2==0) sum_even += B[i, j];
                    else sum_odd += B[i, j];
                }
            }

            //showing array
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(" {0}", B[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("The sum of the even numbers is: {0}", sum_even);
            Console.WriteLine("The sum of the odd numbers is: {0}", sum_odd);






        }

    }
}
