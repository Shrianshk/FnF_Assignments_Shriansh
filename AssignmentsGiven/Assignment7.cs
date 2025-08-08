using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Assignment7
    {
        static bool isPrime(int n)
        {
            if (n <= 1)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
            static void Main(string[] args)
            {
            
            {
                int a = ConsoleUtil.GetInputInt("Enter the Integer");
                if (isPrime(a))
                {
                    Console.WriteLine($"{a} is a prime number");
                }
                else
                {
                    Console.WriteLine($"{a} is not a prime number");
                }
            }

            }
        }
    }

