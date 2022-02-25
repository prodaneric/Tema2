using FakeItEasy;
using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Numerics;
using System.Text;

namespace Tema2
{
    class Task1
    {
        public static void task1()
        {
            //declaring the arrays
            Random rnd = new Random();

            int[] A = new int[5];

            int[,] B = new int[3, 4];

            for (int i = 0; i<A.Length; i++)
            {
                A[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i<3; i++)
            {
                for (int j = 0; j<4; j++)
                {
                    B[i, j] = rnd.Next(1,10);
                }
            }

            //showing the arrays
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write(" {0}",A[i]);
            }

            Console.WriteLine();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(" {0}",B[i, j]);
                }
                Console.WriteLine();
            }

            //finding the max,min and sum from both arrays

            int min1 = int.MaxValue;
            int max1 = int.MinValue;
            int sum1 = 0;
            int product1 = 1;
            int sum_even = 0;

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] < min1) min1 = A[i];
                if (A[i] > max1) max1 = A[i];

                sum1 += A[i];
                product1 *= A[i];
                if (A[i] % 2 == 0) sum_even += A[i];
            }

            Console.WriteLine("The max and min of the first array: {0} , {1}", max1, min1);
            Console.WriteLine("The sum of the first array is: {0}", sum1);
            Console.WriteLine("The product of the first array is: {0}", product1);
            Console.WriteLine("The sum of all even elements in the first array is: {0}", sum_even);

            ////////////////////

            int min2 = int.MaxValue;
            int max2 = int.MinValue;
            int sum2 = 0;
            int product2 = 1;
            int sum_odd_columns = 0;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (B[i, j] < min2) min2 = B[i,j];
                    if (B[i, j] > max2) max2 = B[i, j];

                    sum2 += B[i, j];
                    product2 *= B[i, j];
                    if (j % 2 != 0) sum_odd_columns += B[i, j];
                }
                Console.WriteLine();
            }

            
            Console.WriteLine("\nThe max and min of the second array: {0} , {1}", max2, min2);
            Console.WriteLine("The sum of the second array is: {0}", sum2);
            Console.WriteLine("The product of the second array is: {0}", product2);
            Console.WriteLine("The sum of all numbers on the odd columns of the second array is: {0}", sum_odd_columns);


        }
    }
       
}

