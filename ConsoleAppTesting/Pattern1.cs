using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTesting
{
    class Pattern1
    {
        public static void DisplayPattern1()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int length = arr.Length;
            int space = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (space = i; space < arr.Length; space++)
                {

                    Console.Write(" ");
                    length--;
                }

                for (int j = 0; j <= i; j++)
                {
                    Console.Write(arr[j]);
                }

                Console.Write("\n");
            }
            Console.ReadLine();
        }

    }
}
