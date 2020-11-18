using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityDay1
{
    class Array1
    {
        static void Main()
        {
            int[] a = new int[] { 4, 5, 2, 6 };
            int i, j;
            int len = a.Length;
            
            int temp;
            for (i = 0; i < a.Length; i++)
            {
                for (j = i + 1; j < a.Length - 1; j++)
                {
                    if (a[i] > a[j])
                    {
                        temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }

            }
            for (i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }

            Console.WriteLine("The Smallest element is :{0}", a[0]);
            Console.WriteLine("Enter the number of times the array is to be rotated");
            int k = Convert.ToInt32(Console.ReadLine());
            while(k!=0)
            {
                for (i = 0; i < a.Length - 1; i++)
                {
                    a[i] = a[i + 1];
                    //k++;
                }
                k--;

            }
           
            Console.WriteLine("after rotation");
            for (i = 0; i < a.Length; i++)
            {
                Console.Write(a[i]);
            }

            Console.ReadLine();
        }
    }
}
