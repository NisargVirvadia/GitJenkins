using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityDay1
{
    class Treesandstones
    {
        static void Main()
        {
            //int no_of_entries=Convert.ToInt32(Console.ReadLine());
            //int[] input=new int[no_of_entries];
            int input1;
            input1 = Convert.ToInt32(Console.ReadLine());
            string input = Convert.ToString(input1, 2);
            Console.Write(input);


            //string input = Console.ReadLine();
            int i;
            //for(i=0;i<no_of_entries;i++) input[i]=Convert.ToInt32(Console.ReadLine());
            int max = -1, count;
            Treesandstones ts = new Treesandstones();
            //for(i=0;i<no_of_entries-1;i++){
            for (i = 0; i < input.Length - 1; i++)
            {
                count = 0;
                if (ts.IsOne(input[i]) && ts.IsZero(input[i + 1]))
                {
                    i++; count++;
                    while (ts.IsZero(input[i + 1])) { i++; count++; }
                    if (max < count) max = count;
                }
            }
            if (max == -1) max = 0;
            Console.WriteLine(max);
            Console.ReadKey();
        }
        public bool IsOne(char t)
        {
            if (t == '1') return true;
            return false;
        }
        public bool IsZero(char s)
        {
            if (s == '0') return true;
            return false;
        }
    }
}
