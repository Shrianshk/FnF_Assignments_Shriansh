using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Ex2DataTypes
    {
        static void Main(string[] args)
        {
            int ival = 222;
            long lval = 3543553434;
            float fval = 23.45f;  // "f" is for to convert double precision to single one that is float
            double dval = 34.6666;
            char cval = 'a';
            bool bval = false;

             Console.WriteLine("The value of ival is {0} \n The value of lval is {1} \n The value of fval is {2} \n The value of dval is {3}" +
             "\n The value of cval is {4} \n The value of bval is {5}", ival, lval, fval, dval, cval, bval);
            
            displayUserDetails();
        }
        static void displayUserDetails()
        {
            Console.WriteLine("Enter the name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter the age");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your favourite letter");
            char ch = char.Parse(Console.ReadLine());

            Console.WriteLine($" Name is {name} \n age is {age} \n favourite letter is {ch} ");

        }
    }
}

/* 
 All data types in C# are based on CTS(Common Type System) for >NET framework
 */
