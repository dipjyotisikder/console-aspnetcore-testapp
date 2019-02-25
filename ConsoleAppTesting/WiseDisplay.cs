using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTesting
{
    class WiseDisplay
    {
        public static void Display()
        {

            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int count = 0;
            foreach (int ar in arr)
            {

                if (ar % 3 == 0)
                {
                    for (int i = count; i <= count + 2; i++)
                    {
                        Console.WriteLine("i value is" + i);
                    }

                    count = count + 3;


                    Console.WriteLine(count);
                }



                //Console.WriteLine(ar);

            }


            Console.ReadLine();


        }

    }
}
