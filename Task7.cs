using System;
using System.Collections.Generic;
using System.Text;

namespace Tema2
{
    class Task7
    {
        public static void task7()
        {

            String str;
            String bad_word = "die";

            Console.WriteLine("Enter the string: ");
            str = Console.ReadLine();


            StringBuilder strr = new StringBuilder();
            strr.Append(str);

            if (str.Contains(bad_word))
            {

                int ind = str.IndexOf("die");
                
                for (int i = ind; i<bad_word.Length; i++)
                {
                    strr[i] = '*';
                }

            }

            Console.WriteLine(strr);

        }
        

    }
}
