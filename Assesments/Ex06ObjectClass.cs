using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Object is Universal Datatype in C#. All datatypes in C# is derived from Object class it is reference type . Object is like void*(reference) in C++

namespace ConsoleApp1
{
    internal class Ex06ObjectClass
    {
        static void Main(string[] args)
        {
            object obj = 10; // Boxing - Implicit conversion of any type to object 
            Console.WriteLine("The datatype ios" + obj.GetType());
            Console.WriteLine("The datatype ios" + obj.GetType().Name);

            object obj2 = 23.445f;
            Console.WriteLine("The datatype is "+obj2.GetType().Name);
            float f =(float)obj2;
            Console.WriteLine(f);// Unboxing Explicit conversion of object to its original datatype through Tytpecasting
            // to perform any operation on object u need to convert it into back in its original form

        }
    }
}
