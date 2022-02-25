using System;
using System.Collections.Generic;
using System.Text;

namespace Tema2
{
    class Task6
    {
        public static void task6()
        {
            String str; 

            Console.WriteLine("Enter the string: ");
            str = Console.ReadLine();


            bool change = true;
            var strRes = new StringBuilder(str.Length);
            for (int i = 0; i < str.Length; i++)
            {
                if (change && char.IsLetter(str[i]))
                {
                    strRes.Append(char.ToUpper(str[i]));
                    change = false;
                }
                else
                    strRes.Append(str[i]);

                if (str[i] == '.') change = true;

            }

            Console.WriteLine("The capitalized string: {0}",strRes.ToString());


        }


    }
}
