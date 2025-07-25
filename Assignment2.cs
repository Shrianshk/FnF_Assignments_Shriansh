using System;
using System.Collections.Generic;
using System.Linq;
using System.Text; 
using System.Threading.Tasks;

namespace Assignments
{
    static class ConsoleUtil
    {
        public static string GetInputString(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();
        }
        public static int GetInputInt(string question)
        {
            return int.Parse(GetInputString(question));
        }
        public static double GetInputDouble(string question)
        {
            return double.Parse(GetInputString(question));
        }

    }
    internal class Assignment2
    {
        
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter the size of an arrray");
            int n = ConsoleUtil.GetInputInt("Enter the size of an array");
            Console.WriteLine("Enter the elements of an array");
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                 arr[i] = int.Parse(Console.ReadLine());
            }
            EvenOdd(arr);

        }
        public static void EvenOdd(int[] arr)
        {
            Console.WriteLine("Even Numbers : ");
            for (int i = 0;i < arr.Length;i++)
            {
                if (arr[i]%2== 0)
                {
                    Console.WriteLine(arr[i] + " ");
                }
                
            }
            Console.WriteLine("Odd Numbers : ");
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    Console.WriteLine(arr[i] + " ");
                    
                }

            }
        }
    }
}
