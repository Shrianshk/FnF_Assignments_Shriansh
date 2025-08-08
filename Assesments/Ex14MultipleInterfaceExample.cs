using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    interface IExample
    {
        void Away();
        void near();
       
    }
    interface ISimple
    {
        void go();
        void come();
        void near();
    }
    class Simple : IExample, ISimple
    {
        public void Away()
        {
            Console.WriteLine("Hello Away");
        }
        public void near()
        {
            Console.WriteLine("Hello near");
        }
        public void go()
        {
            Console.WriteLine("Hello go");
        }
        public void come()
        {
            Console.WriteLine("Hello come");
        }
        void ISimple.near()
        {
            Console.WriteLine("ISimple near");
        }
        void IExample.near()
        {
            Console.WriteLine("IExample near");
        }
    }
    internal class Ex14MultipleInterfaceExample
    {
        static void Main(string[] args)
        {
            Simple so= new Simple();
           // IExample s = new Simple ();
           //s.Away();
           // s.near();
            ISimple a = new Simple ();
            a.go();
            a.come();
            a.near();
            so.near();
            IExample e = (IExample) a; // Upcast the same object to the next interfacee
            e.near();

            
        }
    }
}
