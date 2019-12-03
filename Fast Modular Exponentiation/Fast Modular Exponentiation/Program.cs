using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fast_Modular_Exponentiation
{
    class Program
    {
        /*Fast Modular Exponentiation this program results A^B(mod P)*/
        static void Main(string[] args)
        {
            Console.Write("Enter Value Of (A): ");
            long A = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nEnter Value Of (B): ");
            long B = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nEnter Value Of (P): ");
            long P = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nA^B(mod P): {0}", ApowerBmodP(A, B, P));

        }
        // Calculation (A^B) % P 
        public static long ApowerBmodP(long a, long b, long p)
        {
            long ans = Apowerb(a, b); //Function to calculate power of any number (a^b)
            long mul = ans % p;

            return mul;
        }

        // Calculation (a^b)
        public static long Apowerb(long a, long b)
        {
            if (b == 0)
                return 1;
            else
                return a * Apowerb(a, b - 1);
        }
    }
}
