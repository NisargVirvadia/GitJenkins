using System;

namespace Day1Codility
{
    class triangle
    {
        static void Main()
        {
            triangle it = new triangle();
            Console.WriteLine("Enter the Odd Number");
            int n = Convert.ToInt32(Console.ReadLine());
            it.PrintInvertedTraingle(n);
            Console.Read();
        }

        void PrintInvertedTraingle(int n)
        {
            for (int i = n; i > 0; i--)
            {
                for (int j = 0; j < (n - i); j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < (2 * i - 1); j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}