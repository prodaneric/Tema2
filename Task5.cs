using System;
using System.Collections.Generic;
using System.Text;

namespace Tema2
{
    class Task5
    {
        public static void task5()
        {
            String op;
            int res = 0;
            
            do{
                Console.WriteLine("Enter the operation: ");
                op = Console.ReadLine();
            } while (!((op[1].Equals('-') || op[1].Equals('+')) && op.Length < 4));
            


                if (op[1].Equals('-'))
                {
                    int num1 = op[0] - '0';
                    int num2 = op[2] - '0';

                    res = num1 - num2;
                }

                if (op[1].Equals('+'))
                {
                    int num1 = op[0] - '0';
                    int num2 = op[2] - '0';

                    res = num1 + num2;

                }

                Console.WriteLine(res);

                

        }
    }
}
