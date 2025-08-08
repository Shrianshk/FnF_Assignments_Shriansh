using System;
using System.ComponentModel.DataAnnotations;

namespace ConsoleApp1
{
    internal class Ex3CalcProgram
    {
        static string GetStringValue(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();
        }
        static double GetDoubleValue(string question)
        {
            Console.WriteLine(question);
            return double.Parse(Console.ReadLine());
        }

        static double GetResult(double val1, double val2, string operand)
        {
            switch (operand)
            {
                case "+": return val1 + val2;
                case "-": return val1 - val2;
                case "X": return val1 * val2;
                case "/": return val1 / val2;
                default:
                    Console.WriteLine("Invalid Choice");
                    return 0;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Calc Program");
            bool processing = false;
            do
            {
                Console.Clear();
                double val1 = GetDoubleValue("Enter the First Value");

                double val2 = GetDoubleValue("Enter the second Value");

                string operand = GetStringValue("Enter the Operands as + or - or X or /").ToUpper();

                double result = GetResult(val1, val2, operand);

                Console.WriteLine("The result: {0}", result);

                string choice = GetStringValue("Press Y to continue or N to quit");
                processing = choice.ToUpper() == "Y" ? true : false;
            } while (processing);
        }
        static void typecasting() { 
          int ival =123;
        long lval = ival; // Implicit conversion of int to long
            double dval = 123.55;
            lval = (long)dval; // Explicit conversion from double to long
            
            //Convert class is recommended to convert from chnaging one datatype to other rather than typecasting
            lval = Convert.ToInt64(dval); // Convert class is available in System namespace. It has methods to convert from one type to another


        }
    }
}

