using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Ex1ConsoleDemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter the address");
            string address = Console.ReadLine();

            Console.WriteLine($"The Inputs are as follows : \n The name entered is {name }\n The address is {address}");
        }
    }
}
