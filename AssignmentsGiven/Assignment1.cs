using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Assignment1
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Integer ranges from {int.MinValue} to {int.MaxValue}");
            Console.WriteLine($"byte ranges from {byte.MinValue} to {byte.MaxValue}");
            Console.WriteLine($"short ranges from {short.MinValue} to {short.MaxValue}");
            Console.WriteLine($"long ranges from {long.MinValue} to {long.MaxValue}");
            Console.WriteLine($"float ranges from {float.MinValue} to {float.MaxValue}");
            Console.WriteLine($"double ranges from {double.MinValue} to {double.MaxValue}");
            Console.WriteLine($"decimal ranges from {double.MinValue} to {double.MaxValue}");
            Console.WriteLine($"char ranges from {(int)char.MinValue} to {(int)char.MaxValue}");
            
        }
    }
}
