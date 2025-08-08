using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Ex15ExceptionHandling
    {


        [Serializable]
        public class DBFailureException : Exception
        {
            public DBFailureException() { }
            public DBFailureException(string message) : base(message) { }
            public DBFailureException(string message, Exception inner) : base(message, inner) { }

        }
        public static void ThirdException()
        {
            bool isconnected = true;
            Console.WriteLine("The database is connected successfully");
            isconnected = false;
            if (!isconnected)
            {
                Console.WriteLine("Connection Failed");
            }
        }
        static void FirstException()
        {
        RETRY:
            try
            {
                Console.WriteLine("Enter the age ");
                int age = int.Parse(Console.ReadLine());
                Console.WriteLine($"The age is : {age}");
                Console.WriteLine();
                Console.WriteLine("Enter the number to be divided");
                int div = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the number that divides");
                int di = int.Parse(Console.ReadLine());
                int quotient = div / di;
                Console.WriteLine($"The quotient is : {quotient}");

            }
            catch (OverflowException ex)
            {
                Console.WriteLine($"THE EXCEPTION IS : {ex}");
                Console.WriteLine($"The input must be within {int.MinValue} and {int.MaxValue}");
                goto RETRY;
            }
            catch (FormatException ex1)
            {
                Console.WriteLine("The input should be in correct format");
                goto RETRY;
            }
            catch (ArgumentNullException ex2)
            {
                Console.WriteLine("The input should not be null");
                Console.WriteLine($"The Exception is : {ex2}");
                goto RETRY;
            }
            catch (Exception a)
            {
                Console.WriteLine("Divided by zero");
            }
            finally
            {
                // U cannot have jump statements like goto,break,
            }
        }

        public class ConsoleUti
        {
            public static string get(string question)
            {
                Console.WriteLine(question);
                string str = Console.ReadLine();
                return str;
            }
        }

            public static void SecondException()
            {
                string uname = ConsoleUti.get("Enter the name ");
                string pass = ConsoleUti.get("Enter the password");
                if (uname == "admin" && pass == "admin")
                {
                    Console.WriteLine("Welcome to application");
                }
                else
                {
                    throw new UnauthorizedAccessException("Invalid username and password");
                }


            }


            static void Main(string[] args)
            {


                try
                {
                    SecondException();
                }
                catch (UnauthorizedAccessException)
                {
                    Console.WriteLine("Invalid credentials");
                }
                try
                {
                    ThirdException();
                }
                catch (DBFailureException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Custom Exception :{e}");
                }

            }
        
    }
}

