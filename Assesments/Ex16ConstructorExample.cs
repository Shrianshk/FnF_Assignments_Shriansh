using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Superclass
    {
        public Superclass()
        {
            Console.WriteLine("This is Superclass Constructor");
        }
        public Superclass(string str) : this()
        {
            Console.WriteLine($"The str Superclass is called : {str}");
        }


    }
    class Childclass : Superclass
    {
        public Childclass(string msg) : base(msg)
        {
            {
                Console.WriteLine("this is childclass constructor");
            }
        }
    }
    class DerivedClass1 : Childclass
    {
        public DerivedClass1(string msg) : base(msg)
        {
            {
                Console.WriteLine("This is derivedclass constructor");
            }
        }
    }
            internal class Ex16ConstructorExample
            {
                static void Main(string[] args)
                {
                    //perclass superclass = new Superclass();
                    DerivedClass1 derivedclass = new DerivedClass1("jhello");
                    //First invokes the constructor of Supercalass
                }
            }
        
 }

