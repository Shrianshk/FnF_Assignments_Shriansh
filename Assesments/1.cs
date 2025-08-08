using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Ex19CollectionsExample
    {
        static void ArrayList()
        {
            ArrayList list = new ArrayList();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);
            Console.WriteLine("Total count in list is : " + list.Count);
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
            for (int i = 0; i < list.Count; i++)
            {
                if ((int)list[i] == 4)
                {
                    Console.WriteLine("item found");
                }
                else continue;
            }

        }
        private static void hashtable()
        {
            Hashtable ht = new Hashtable();
            ht.Add("a", 1);
            ht.Add("b", 2);
            ht.Add("c", 3);
            ht.Add("d", 4);
            ht.Add("e", 5);
            ht.Add("f", 6);
            foreach(string key in ht.Keys)
            {
                Console.WriteLine($"key is {key} and value is {ht[key]}");
            }
        }
        static Hashtable users = new Hashtable();
        public static void RegisterUser()
        {

            Console.Write("Enter new username: ");
            string username = Console.ReadLine();

            if (users.ContainsKey(username))
            {
                Console.WriteLine("Username already exists. Try a different one.");
                return;
            }

            Console.Write("Enter new password: ");
            string password = Console.ReadLine();

            users.Add(username, password);
            Console.WriteLine("Registration successful!");

        }
        public static void LoginUser()
        {

            Console.Write("Enter username: ");
            string username = Console.ReadLine();

            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            if (users.ContainsKey(username))
            {
                if ((string)users[username] == password)
                {
                    Console.WriteLine("Login successful! Welcome, " + username + ".");
                }

                else
                {
                    Console.WriteLine("Incorrect password.");
                }
            }
            else
            {
                Console.WriteLine("Username not found.");
            }
        }


            
            static void Main(string[] args)
        {
            //ArrayList();
            //hashtable();
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("Wlcome to Login Page");

                Console.WriteLine("\nChoose an option:");
                Console.WriteLine("1.  Select R to Register");
                Console.WriteLine("2. Select L to Login");
                string str = Console.ReadLine();

                switch (str)
                {

                    case "R":
                        RegisterUser();
                        break;
                    case "L":
                        LoginUser();
                        break;

                }
            }

        }
    }
}
