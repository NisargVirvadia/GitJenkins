using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityDay1
{
    class Fact
    {

        static void Main()
        {
            int fact = 1;
            int i;
            List<int> li = new List<int>();
            Console.WriteLine("Lower Range :");
            int Lr = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Higher Range :");
            int Hr = Convert.ToInt32(Console.ReadLine());
            for (i = Lr; i <= Hr; i++)
            {

                if (fact < Hr)
                {
                    fact *= i;
                    if (fact < Hr)
                        li.Add(fact);
                }
                //Count++;
            }

           /* foreach (int j in li)
            {
                Console.WriteLine(j);
            }*/

            Console.WriteLine(li.Count);
            Console.ReadLine();
        }
    }
}
    