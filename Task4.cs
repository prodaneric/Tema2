using System;
using System.Collections.Generic;
using System.Text;

namespace Tema2
{
    class Task4
    {
        public static void task4()
        {

            
            Random rnd = new Random();

            //declaring initial matrix
            int[,] B = new int[3, 4];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    B[i, j] = rnd.Next(1, 10);
                }
            }

            Console.WriteLine();

            //showing the matrix
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(" {0}", B[i, j]);
                }
                Console.WriteLine();
            }

            //multplying by a number the user chooses
            Console.WriteLine("What number do you want to multiply by? ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    B[i, j] *= num;
                }
            }

            //showing the changed matrix
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(" {0}", B[i, j]);
                }
                Console.WriteLine();
            }




            //declaring the second matrix

            int[,] C = new int[3, 4];



            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    C[i, j] = rnd.Next(1, 10);
                }
            }

            Console.WriteLine();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(" {0}", C[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            //adding together the two matrixes


            int[,] D = new int[3, 4];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    D[i, j] = C[i, j] + B[i, j];
                }
                Console.WriteLine();
            }


            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(" {0}", D[i, j]);
                }
                Console.WriteLine();
            }

            //multplying them

            int[,] E = new int[3, 4];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    E[i, j] = C[i, j] * B[i, j];
                }
                Console.WriteLine();
            }


            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(" {0}", E[i, j]);
                }
                Console.WriteLine();
            }



        }

    }
}
