using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projecteuler_10001thprime
{
    class Program
    {
        public static bool isPrime(double x)
        {
            double i;
            for (i = 2; i < x; i++)
            {
                if (x % i == 0)
                    return false;
            }
            return true;
        }


        public static void Main()
        {
            int i = 2;
            int count = 0;
            while (count < 10001)
            {
                if (isPrime(i))
                {
                    count++;
                }
                i++;
                
            }
            Console.WriteLine(i + "," + count);
            Console.ReadLine();

        }
    }
}
