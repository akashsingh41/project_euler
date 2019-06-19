using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projecteuler_evenfibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int limit = 4000000;
            int x = 1, y = 2,z;
            int sum = 2;
            while (y < limit)
            {
                z = x + y;
                if (z%2==0)
                {
                    sum += z;
                }
                x = y;
                y = z;
            }

            Console.WriteLine(sum);
        }
    }
}
