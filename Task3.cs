using System;
using System.Collections.Generic;
using System.Text;

namespace Tema2
{
    class Task3
    {
        public static char ciff(char ch, int key)
        {
            if (!char.IsLetter(ch))
            {

                return ch;
            }

            char d = char.IsUpper(ch) ? 'A' : 'a';

            return (char)((((ch + key) - d) % 26) + d);

        }


        public static string enciff(string txt, int key)
        {
            string ret = string.Empty;
            foreach (char ch in txt)
                ret += ciff(ch, key);



            return ret;
        }


        public static string deciff(string input, int key)
        {
            return enciff(input, 26 - key);
        }


        public static void mainn()
        {

            Console.WriteLine("Enter a message:");
            string mess = Console.ReadLine();
            Console.WriteLine("\n");
            //////
            ///
            Console.Write("Enter key: ");
            int key = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            ////
            ///

            Console.WriteLine("Encrypted text: ");

              string encmess = enciff(mess, key);
               Console.WriteLine(encmess);
              Console.Write("\n");

            Console.WriteLine("Decrypted text:");

             string t = deciff(encmess, key);
              Console.WriteLine(t);
              Console.Write("\n");

        }
    }


}

