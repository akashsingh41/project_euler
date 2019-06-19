using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projecteuler_productofprimes
{
    class Program
    {
        public static bool isPrime(long x)
        {
            long i;
            for (i = 2; i < x; i++)
            {
                if (x % i == 0)
                    return false;
            }
            return true;
        }

        public static void Main()
        {
            int limit = 2000000;
            long sum = 0;
            for (int i = 2; i < limit; i++)
            {
                if (isPrime(i))
                {
                    Console.WriteLine(i);
                    sum += i;
                }
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
