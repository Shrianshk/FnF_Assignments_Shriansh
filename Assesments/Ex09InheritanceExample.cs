using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Baseclass // This class is Internal . Internal classes are accessiblwe only within the same assembly/project. if we want to access it outside the project then make the class public.
    {
         public void Display()
        {
            Console.WriteLine("Super class");
        }
    }
    
    class DerivedClass : Baseclass // this is how the class is inherited in the C#
    { 
        public void Show() 
        {
            Console.WriteLine("Derived Class");
        }
    }
    // A derived class that inherits from the Baseclass is required if U want to add new functionality or override existing functionality of the base class. A class is immutable by default , meaning you canot change its functionality unless you inherit from it. (Open-closed Principle of SOLID)

    // c# does not support multiple inheritance , meaning a class cannot be inherit from multiple classes or more than one base class 
    internal class Ex09InheritanceExample
    {
        static void Main(string[] args)
        {
           DerivedClass derivedClass = new DerivedClass();
            derivedClass.Show();    
             derivedClass.Display();
        }
    }
}
