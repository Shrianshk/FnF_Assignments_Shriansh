using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Ex05ArraysExample
    {
        static void Main(string[] args)
        {
            OneDArray();
            TwoDArray();
            JaggedDArray();

        }
        static void OneDArray()
        {
            string[] names = new string[5];
            names[0] = "A";
            names[1] = "B";
            names[2] = "C";
            names[3] = "D";
            names[4] = "E";

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(names[i]);
            }

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
        static void JaggedDArray() {
            int[][]  school = new int[3][];
            school[0] = new int[] { 1, 2, 3, 4 };
            school[1] = new int[] { 1, 2, 3 };
            school[2] = new int[] { 1, 2 };

            for (int i = 0;i < 3;i++)
            {
                foreach (int s in school[i])
                {
                    Console.WriteLine(s);
                }
            }
        }
        static void TwoDArray()
        {
            int[,] marks = new int[3,3];
            marks = new int[,]
            {
                { 90, 85,80 },
                { 55,65,75},
                { 80,90,70},

            };
            for (int i = 0;i<  marks.GetLength(0); i++)
            {
                for (int j = 0;j< marks.GetLength(1); j++)
                {
                    Console.WriteLine($"{marks[i,j]} ");
                }
                Console.WriteLine();
            }
            {

            }
        }
        static void inputArray()
        {
            Console.WriteLine("Enter the size of array ");
            int size =int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the datatype of array like int, string or float");
            string datatype = Console.ReadLine();

            switch (datatype)
            {
                case "int":
                    int[]  arr1 = new int[size];
                    for(int i = 0; i < arr1.Length; i++)
                    {
                       ((int[])arr1)[i] = int.Parse(Console.ReadLine());
                    }
                    break;

            }

        }
    }
}
