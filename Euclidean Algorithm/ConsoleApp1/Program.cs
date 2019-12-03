using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        /* This Program takes two inputs from user on console and output their GCD.*/
        static void Main(string[] args)
        {
            
                Console.Write("Please enter the 1st number of input: ");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Please enter the 2nd number of input: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("GCD of " + num1 + " and " + num2 + " is: " + Calculation(num1, num2));

            

           
        }
        public static int Calculation(int num1, int num2)
        {
            if (num2 == 0)
            {
                return num1;
            }

            return Calculation(num2, num1 % num2);
        }

    }
}
