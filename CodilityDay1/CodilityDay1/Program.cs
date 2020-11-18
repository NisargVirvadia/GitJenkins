using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityDay1
{
    class Program
    {
        public static bool IsEven(int i)
        {
            if(i%2==0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool IsOdd(int i)
        {
            if(i%2!=0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            int a;
            int b;
            int counteven = 0;
            int countodd = 0;
            Console.WriteLine("Enter the 2 numbers");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            for(int i=a;i<=b;i++)
            {
                if(IsEven(i))
                {
                    counteven++;
                }
                else if(IsOdd(i))
                {
                    countodd++;
                }
            }
            Console.WriteLine("Even number:{0},Odd Number:{1}", counteven, countodd);
            Console.ReadLine();


        }
    }
}
