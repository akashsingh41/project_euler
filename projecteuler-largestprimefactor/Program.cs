using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projecteuler_largestprimefactor
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

        public static List<double> Factorize(double input)
        {
            List<double> factors = new List<double>();
            double root = Math.Sqrt(input);

            while (input % 2 == 0)
            {
                factors.Add(2);
                input /= 2;
            }

            for (double i = 3; i < root; i++)
            {
                if (input % i == 0)
                {
                    factors.Add(i);
                    input /= i;
                }
            }
            return factors;
        }


        static void Main(string[] args)
        {
            double input = 600851475143;
            //Console.WriteLine(input);

            foreach (double x in Factorize(input))
            {
                //if(isPrime(x))
                {
                    Console.WriteLine(x);
                    //return;
                }
            }

            Console.ReadLine();
        }
    }
}
