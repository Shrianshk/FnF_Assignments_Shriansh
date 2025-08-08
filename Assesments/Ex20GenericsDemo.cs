using SampleConApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SampleConApp.GenericExample;
using Microsoft.VisualBasic;

//Generics is a feature of .NET that can allow to create classes, methods and interfaces that can work on any kind of data type. They are similar to templates in C++. They are said to be type-safe, meaning that they can enforce type constraints at compile time, reducing runtime errors. U dont have to unbox the data when U use generics, as they are already type-safe.

namespace ConsoleApp1
{
    internal class Ex20GenericsDemo
    {
        static void Main(string[] args)
        {
            //listExample();
            //HashsetExample();
            //HashsetEmployee();
            DictionaryExample();
        }
        //private static void listExample()
        //{
        //    List<string> names = new List<string>();
        //    names.Add("Jane");
        //    names.Add("john");
        //    names.Add("Jade");
        //    names.Add("Jannifer");
        //    names.Add("Jason");
        //    names.Insert(2, "joddy");

        //    foreach (string name in names)
        //    {
        //        Console.WriteLine(name.ToUpper());
        //    }
        //    string nametofind = ConsoleUtil.GetInputString("ENter the name");
        //    if (!names.Contains(nametofind))
        //    {
        //        Console.WriteLine("Entered name does not exist");
        //    }
        //    else
        //    {
        //        //for(int i =0; i < names.Count; i++)
        //        //{
        //        //    if(names[i] == nametofind)
        //        //    {
        //        //        Console.WriteLine("Enterd name is found at indes :" + i);
        //        //        break;
        //        //    }
        //        //}
        //        var index = names.IndexOf(nametofind);
        //        Console.WriteLine($"your name is found at index {index}");
        //    }
            

        //}
        private static void HashsetExample()
        {
            HashSet<string> names = new HashSet<string>();
            names.Add("John");
            names.Add("John");
            names.Add("Jade");
            names.Add("Jode");
            names.Add("Jade");
            names.Add("Jane");
            if (!names.Add("John"))
            {
                Console.WriteLine("John is already in the list");
            }

            Console.WriteLine("Total names in set are :" + names.Count );
            foreach (string name in names)
            {
                Console.WriteLine(name.ToUpper());
            }

        }
        private static void HashsetEmployee()
        {
            HashSet<Employee> employees = new HashSet<Employee>();
            employees.Add(new Employee { EmpID = 1, EmpName = "John", EmpAddress = "New York", EmpSalary = 50000, Designation = "Manager" });
            employees.Add(new Employee { EmpID = 2, EmpName = "Jane", EmpAddress = "Los Angeles", EmpSalary = 60000, Designation = "Developer" });
            employees.Add(new Employee { EmpID = 3, EmpName = "Doe", EmpAddress = "Chicago", EmpSalary = 55000, Designation = "Tester" });
            employees.Add(new Employee { EmpID = 4, EmpName = "Alice", EmpAddress = "Houston", EmpSalary = 70000, Designation = "Designer" });
            employees.Add(new Employee { EmpID = 5, EmpName = "Bob", EmpAddress = "Phoenix", EmpSalary = 65000, Designation = "Analyst" });
            employees.Add(new Employee { EmpID = 1, EmpName = "John", EmpAddress = "New York", EmpSalary = 50000, Designation = "Manager" });
            employees.Add(new Employee { EmpID = 1, EmpName = "John", EmpAddress = "New York", EmpSalary = 50000, Designation = "Manager" });

            foreach (Employee emp in employees)
            {
                Console.WriteLine($"{emp.EmpName} earns a salary of {emp.EmpSalary:C}");
            }
        }

        // similar to hashtable , but it is type-safe and does not allow null keys.it is a Collection of key-value pairs.
        // Each item in didctionary is key value pair<Tkey,Tvalue> class where Tkey and Tvalue represents the datatyps taht u want to useforthe key and value respectively

        private static void DictionaryExample()
        {
            Dictionary<string,string> dic = new Dictionary<string,string>();
            dic.Add("John", "john123");
            dic.Add("Jade", "jade123");
            dic.Add("Jode", "jode123");
            dic.Add("Jane", "jane123");
            dic.Add("Jojo", "jojo123");

            var username = ConsoleUtil.GetInputString("Enter the name");
            var password = ConsoleUtil.GetInputString("Enter the password");
            if(dic.ContainsKey("username") && dic[username]==password)
            {
                Console.WriteLine("Login is Successful");
            }
            else
            {
                Console.WriteLine("Login failed, invalid credentials");
            }
            if (!dic.ContainsKey("username"))
            {
                Console.WriteLine("user does not exist");
            }
        }
    }
}
