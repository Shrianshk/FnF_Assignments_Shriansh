using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    
    internal class Ex17ParametersDemo
    {
        public static void NormalParameter(int x) => Console.WriteLine($"Normal parameter : {x+1}");

        public static void AddFunction(int a, int b, out int result) => result = a + b; //Lambda Method, Single line method

        //Params Example
        public static long AddNumbers(params int[] numbers)
        {
            long sum = 0;
            foreach (int i in numbers) { sum += i; }
            return sum;

        }

        //Ref Parameters
        public static void Calculate(int a, int b, ref double Add, ref double substract, ref double multiply,ref double divide)
        {
            Add = a + b;
            substract = a - b;
            multiply = a * b;
            if (b != 0)
            {
                divide = a / b;
            }
            else { Console.WriteLine("Divide by zero"); }
        }
        static void Main(string[] args)
        {
            //int x = 20;
            //Console.WriteLine(x);
            //NormalParameter(x);
            //Console.WriteLine(x);// value of x does not change after coming from function

            //int result; // while using out the variqable should not be initialized
            //AddFunction(10,20,out result); // out result is given as a parameter to method without oinitializing but it will get the value which is returned in function
            //Console.WriteLine($"Addition is {result}");

            double divide=0;double multiply=0;double Add = 0;double substract = 0;
            Calculate(20, 10, ref Add , ref substract, ref multiply, ref divide);
            Console.WriteLine("add is "+ Add + "  substract is : "+ substract +" multiply is "+ multiply+" divide is "+divide);
            long sum = AddNumbers(1, 2, 4, 3, 5, 7, 7, 7, 8, 5);
            Console.WriteLine(sum);
        }
    }
}
