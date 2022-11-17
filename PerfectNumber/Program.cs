using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfectNumber
{
    class Program
    {
        public static int FindFactor(int input)
        {
            int sum = 0;
            for (int i = 1; i < input; i++)
            {
                if(input%i==0)
                {
                    sum = sum + i;
                }
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int input =int.Parse(Console.ReadLine());
            int result = FindFactor(input);
            if (input == result)
            {
                Console.WriteLine($"{input} is a perfect number");
            }
            else
            {
                Console.WriteLine($"{input} is not perfect number");
            }
            }
        }
    }

