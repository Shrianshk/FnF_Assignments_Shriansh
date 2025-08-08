using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    interface Babaloo
    {
        void tung(string bat);
        void bambardilo();
        
       
    }
    class Brainrot : Babaloo
    {
        public void tung(string bat)
        {
            Console.WriteLine($"{bat}");
        }
        public void bambardilo() {
            Console.WriteLine("Bombardilo Crocodilo");
        }
    }
    internal class Ex12InterfaceDemo
    {
        static void Main(string[] args)
        {
            Brainrot br = new Brainrot();
            br.tung("The great bat");
            br.bambardilo();
        }
    }
}
