using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projecteuler_sumofprimes
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
        static void Main(string[] args)
        {
            int limit = 2000000;
            long count = 0;
            for (int i = 0; i < limit; i++)
            {
                if (isPrime(i))
                {
                    count += i;
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine(count);
            Console.ReadLine();
        }
    }
}
