using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Similar to pointers in c/c++

namespace ConsoleApp1
{
    delegate double dfunc(int a, int b);
    internal class Ex18DelegateExample
    {
        public static void operation(dfunc func) // I am passing a delegate that is function as an argument to other function
        {
            Console.WriteLine("Enter first number ");
            int v1 =int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number ");
            int v2 = int.Parse(Console.ReadLine());
            double res = func(v1, v2);
            Console.WriteLine(res);
            
        }
        static void InvokeFunc(Func <double,double,double> func)
        {
            Console.WriteLine("Enter first number ");
            int v1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number ");
            int v2 = int.Parse(Console.ReadLine());
            double res = func(v1, v2);
            Console.WriteLine(res);
        }
        public static double add(int a, int b )
        {
            return a + b;
        }
        public static double substract(int a, int b)
        {
            return a - b;
        }
        public static double Gen(double a, double b)
        {
            return a * b;
        }

        static void Main(string[] args)
        {
            dfunc f = new dfunc(add);
            operation(f);
            InvokeFunc(Gen);

            

            
        }
    }
}
