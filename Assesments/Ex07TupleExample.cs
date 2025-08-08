using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Ex07TupleExample
    {
        static void Main(string[] args)
        {
            var d = ("Hello", 45);
            Console.WriteLine($"The word is {d.Item1} and number is {d.Item2}");
            Console.WriteLine("The datatype is "+ d.GetType().Name);

            var person = (Name: "John", Age: 40, City: "New York");
            Console.WriteLine($"name is {person.Name} from {person.City} and age is {person.Age} ");

            var (latitude, City) = getcoordinates();
            Console.WriteLine($"latitude is {latitude} and city is {City}");

        }
        // Implement a method that returns a tuple with one double and one string
        static (double,string) getcoordinates()
        {
            return (45.666, "Latur");
        }
        
        

        }
    }

