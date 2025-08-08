using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Enums are user defined datatypes (UDTs) that are used to define named constants.
// If you have a set of related constants , you can use an enum to define them im single type.
// All Enum 

namespace ConsoleApp1
{
    enum Days : int // we can define the datatype of enum here
    {
        Monday=1, 
        Tuesday=2 ,
        Wednesday=3,
        Thursday=4,
        Friday=5,
        Saturday=6,
        Sunday =7
            
    }
    internal class Ex04EnumsExample
    {
        static void Main(string[] args)
        {
         Days d1 = Days.Monday;
            Console.WriteLine($"The selected date is {d1} and its integral value is {(long)d1} ");

            Console.WriteLine("Enter the day from the list belowu want to start work");
            Array values = Enum.GetValues(typeof(Days)); // Gets the values of the enums . The enum reference is  obtained using typeof Operator

            foreach (Days d in values) {
                Console.WriteLine(d);
            }
            string dayinput = Console.ReadLine();
            Days day = Enum.Parse<Days>(dayinput); // case of insensetive parsing 
            Console.WriteLine("The day selected is " + day);

        }
    }
}
