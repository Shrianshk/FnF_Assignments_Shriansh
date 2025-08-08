using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConApp.OpearatorOverload
{
    class Employee12
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public static Employee12 operator + (Employee12 left, double right)
        {
            left.Salary += right;
            return left;
        }
        public static Employee12 operator - (Employee12 left, double right)
        {
            left.Salary -= right;
            return left;
        }

    }
}
namespace SampleConApp.OpearatorOverload
{
    internal class Ex23OperatorOverloading
    {
        static void Main(string[] args)
        {
            Employee12 employee = new Employee12 { Id = 2, Name = "John", Salary = 6000 };
            Console.WriteLine($"Salary of {employee.Name} is {employee.Salary}");
            employee += 5000;
            Console.WriteLine($"Salary of {employee.Name} is {employee.Salary}");
            employee -= 2000;
            Console.WriteLine($"Salary of {employee.Name} is {employee.Salary}");

        }
    }
}
