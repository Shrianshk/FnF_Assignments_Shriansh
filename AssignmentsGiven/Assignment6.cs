using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignments
{
    
    internal class Assignment6
    {
        //static bool isValidDate(int year, int month, int day)
        //{
        //    try
        //    {
        //        DateTime dt = new DateTime(year, month, day);
        //        return true;
        //    }
        //    catch 
        //    {
        //      return false;
        //    }
        //}
        public static void Takeinput()
        {
            int year = ConsoleUtil.GetInputInt("Enter the year ");
            int month = ConsoleUtil.GetInputInt("Enter the month ");
            int day = ConsoleUtil.GetInputInt("Enter the day ");


            bool valid = isValidate(year, month, day);

            if (valid)
                Console.WriteLine("The entered date is valid.");
            else
                Console.WriteLine("The entered date is invalid.");

        }

        static Hashtable ht = new Hashtable();


        static bool isValidate(int year, int month, int day)
        {
            ht.Add(1, 31);
            ht.Add(2, 28);
            ht.Add(3, 31);
            ht.Add(4, 30);
            ht.Add(5, 31);
            ht.Add(6, 30);
            ht.Add(7, 31);
            ht.Add(8, 31);
            ht.Add(9, 30);
            ht.Add(10, 31);
            ht.Add(11, 30);
            ht.Add(12, 31);

            if ((year%4==0 && year%100!=0) || (year % 400 == 0)){
                ht[2] = 29;
            }
            if(month<=12 && month>1 && day>1 && day <= (int)ht[month])
            {
                return true;
            }
            return false;
        }
        
        static void Main(string[] args)
        {
            Takeinput();
         
        }
    }
}
