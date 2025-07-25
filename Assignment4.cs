using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Assignment4
    {
        static void Main()
        {
            Console.WriteLine("Enter the data type of the array (int, double, string):");

            string dataType = ConsoleUtil.GetInputString("Enter the data type of the array (int, double, string)");


            int size = ConsoleUtil.GetInputInt("Enter the size of array");
            takeinput(dataType, size);

        }
        static void takeinput(string dataType, int size)
        {
            switch (dataType)
            {
                case "int":
                    int[] intArray = new int[size];
                    Console.WriteLine("Enter the integer values:");
                    for (int i = 0; i < size; i++)
                    {
                        Console.Write($"Element [{i}]: ");
                        intArray[i] = int.Parse(Console.ReadLine());
                    }
                    Console.WriteLine("Array contents:");
                    foreach (int item in intArray)
                    {
                        Console.Write(item + " ");
                    }
                    break;

                case "double":
                    double[] doubleArray = new double[size];
                    Console.WriteLine("Enter the double values:");
                    for (int i = 0; i < size; i++)
                    {
                        Console.Write($"Element [{i}]: ");
                        doubleArray[i] = double.Parse(Console.ReadLine());
                    }
                    Console.WriteLine("Array contents:");
                    foreach (double item in doubleArray)
                    {
                        Console.Write(item + " ");
                    }
                    break;

                case "string":
                    string[] stringArray = new string[size];
                    Console.WriteLine("Enter the string values:");
                    for (int i = 0; i < size; i++)
                    {
                        Console.Write($"Element [{i}]: ");
                        stringArray[i] = Console.ReadLine();
                    }
                    Console.WriteLine("Array contents:");
                    foreach (string item in stringArray)
                    {
                        Console.Write(item + " ");
                    }
                    break;

                default:
                    Console.WriteLine("Invalid data type entered.");
                    break;


            }
        }

    }
}

